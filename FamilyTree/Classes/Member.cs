using FamilyTree.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTree.Classes
{
    public class Member
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Address { get; set; }
        public int OccupationID { get; set; }
        public int HometownID { get; set; }
        public bool isRoot { get; set; }
        public int Generation { get; set; }

        public int AddMember(string fullName, string gender, DateTime birthDate, string address, int occupationID, int hometownID, bool isRoot, int generation)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Members (FullName, Gender, BirthDate, Address, OccupationID, HometownID, isRoot, Generation) " +
                               "VALUES (@FullName, @Gender, @BirthDate, @Address, @OccupationID, @HometownID, @isRoot, @Generation); " +
                               "SELECT CAST(scope_identity() AS int)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@OccupationID", occupationID);
                command.Parameters.AddWithValue("@HometownID", hometownID);
                command.Parameters.AddWithValue("@isRoot", isRoot);
                command.Parameters.AddWithValue("@Generation", generation);

                int newMemberID = (int)command.ExecuteScalar();
                return newMemberID;
            }
        }

        public bool DeleteMembers(List<int> memberIDs)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    foreach (int memberID in memberIDs)
                    {
                        // Xóa các bản ghi liên quan trong MemberRelationships
                        string deleteRelationshipsQuery = "DELETE FROM MemberRelationships WHERE MemberID1 = @MemberID OR MemberID2 = @MemberID";
                        SqlCommand deleteRelationshipsCommand = new SqlCommand(deleteRelationshipsQuery, connection, transaction);
                        deleteRelationshipsCommand.Parameters.AddWithValue("@MemberID", memberID);
                        deleteRelationshipsCommand.ExecuteNonQuery();

                        // Xóa các bản ghi liên quan trong MemberAchievements
                        string deleteAchievementsQuery = "DELETE FROM MemberAchievements WHERE MemberID = @MemberID";
                        SqlCommand deleteAchievementsCommand = new SqlCommand(deleteAchievementsQuery, connection, transaction);
                        deleteAchievementsCommand.Parameters.AddWithValue("@MemberID", memberID);
                        deleteAchievementsCommand.ExecuteNonQuery();

                        // Xóa các bản ghi liên quan trong MemberDeaths
                        string deleteDeathsQuery = "DELETE FROM MemberDeaths WHERE MemberID = @MemberID";
                        SqlCommand deleteDeathsCommand = new SqlCommand(deleteDeathsQuery, connection, transaction);
                        deleteDeathsCommand.Parameters.AddWithValue("@MemberID", memberID);
                        deleteDeathsCommand.ExecuteNonQuery();

                        // Xóa bản ghi trong Members
                        string deleteMemberQuery = "DELETE FROM Members WHERE MemberID = @MemberID";
                        SqlCommand deleteMemberCommand = new SqlCommand(deleteMemberQuery, connection, transaction);
                        deleteMemberCommand.Parameters.AddWithValue("@MemberID", memberID);
                        deleteMemberCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return true;
                }
                catch
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }



            public int GetMemberGeneration(int memberID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Generation FROM Members WHERE MemberID = @MemberID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberID", memberID);

                return (int)command.ExecuteScalar();
            }
        }

        public  Member LoadMember(int id)
        {
            string query = "SELECT * FROM Members WHERE MemberID = @MemberID";
            Member member = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberID", id);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Khởi tạo một đối tượng Member và gán thông tin từ dữ liệu đọc được
                    member = new Member()
                    {
                        MemberID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Gender = reader.GetString(2),
                        BirthDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                        Address = reader.GetString(4),
                        OccupationID = reader.GetInt32(5),
                        HometownID = reader.GetInt32(6),
                        isRoot = reader.GetBoolean(7),
                        Generation = reader.GetInt32(8)
                    };
                }
            }

            return member;
        }

        public Tuple<int, int> LoadMemberDeaths(int memberDeathID)
        {
            string query = @"
                SELECT 
                    CauseID,
                    BurialPlaceID
                FROM 
                    MemberDeaths
                WHERE
                    MemberDeathID = @MemberDeathID
            ";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberDeathID", memberDeathID);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        int causeID = reader.GetInt32(0);
                        int burialPlaceID = reader.GetInt32(1);
                        reader.Close();

                        // Trả về Tuple chứa CauseID và BurialPlaceID
                        return Tuple.Create(causeID, burialPlaceID);
                    }
                    else
                    {
                        MessageBox.Show("No data found for the given MemberDeathID.", "Error");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            // Trả về giá trị mặc định nếu có lỗi
            return Tuple.Create(-1, -1);
        }

        public bool UpdateMember(Member member)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Members SET FullName = @FullName, Gender = @Gender, BirthDate = @BirthDate, Address = @Address, OccupationID = @OccupationID, HometownID = @HometownID WHERE MemberID = @MemberID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@FullName", member.Name);
                    command.Parameters.AddWithValue("@Gender", member.Gender);
                    command.Parameters.AddWithValue("@BirthDate", member.BirthDate);
                    command.Parameters.AddWithValue("@Address", member.Address);
                    command.Parameters.AddWithValue("@OccupationID", member.OccupationID);
                    command.Parameters.AddWithValue("@HometownID", member.HometownID);
                    command.Parameters.AddWithValue("@MemberID", member.MemberID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;

            }
            catch { return false; }
            
        }

        public bool UpdateMemberDeath(int memberDeathID, int causeID,int placeID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "UPDATE MemberDeaths SET CauseID = @CauseID, BurialPlaceID = @BurialPlaceID WHERE MemberDeathID = @MemberDeathID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MemberDeathID", memberDeathID);
                    command.Parameters.AddWithValue("@CauseID", causeID);
                    command.Parameters.AddWithValue("@BurialPlaceID", placeID);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch { return false; }            

        }

        
        // Lấy danh sách thành viên
        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MemberID, FullName, Gender, BirthDate, Address, OccupationID, HometownID, isRoot, Generation FROM Members";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Member member = new Member
                        {
                            MemberID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Gender = reader.GetString(2),
                            BirthDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                            Address = reader.GetString(4),
                            OccupationID = reader.GetInt32(5),
                            HometownID = reader.GetInt32(6),
                            isRoot = reader.GetBoolean(7),
                            Generation = reader.GetInt32(8)
                        };
                        members.Add(member);
                    }
                }
            }
            return members;
        }



        public List<Member> GetRootMembers()
        {
            List<Member> members = new List<Member>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MemberID, FullName, Gender, BirthDate, HometownID, OccupationID, Address, Generation FROM Members WHERE isRoot = 1";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(new Member
                    {
                        MemberID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Gender = reader.GetString(2),
                        BirthDate = reader.IsDBNull(3) ? (DateTime?)null : reader.GetDateTime(3),
                        Address = reader.GetString(6),
                        OccupationID = reader.GetInt32(5),
                        HometownID = reader.GetInt32(4),
                        isRoot = true, // Giá trị mặc định
                        Generation = reader.GetInt32(7) // Kiểm tra chỉ số cột cho Generation
                    });
                }
            }
            return members;
        }

        // Lấy danh sách thành tích
        public Dictionary<int, string> GetAchievementTitles()
        {
            Dictionary<int, string> achievements = new Dictionary<int, string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT AchievementID, AchievementName FROM Achievements";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int achievementID = reader.GetInt32(0);
                    string achievementName = reader.GetString(1);
                    achievements.Add(achievementID, achievementName);
                }
            }
            return achievements;
        }
        // Thêm thành tích vào cơ sở dữ liệu
        public bool AddAchievement(int memberID, int achievementID, DateTime? achievementDate)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO MemberAchievements (MemberID, AchievementID, AchievementDate) VALUES (@MemberID, @AchievementID, @AchievementDate)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.Parameters.AddWithValue("@AchievementID", achievementID);
                    command.Parameters.AddWithValue("@AchievementDate", achievementDate);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception) {
                return false;
            }       
        }
        // Thêm kết thúc vào cơ sở dữ liệu
        public bool AddMemberDeath(int memberID, DateTime? deathDate, int causeID, int burialPlaceID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    // Chèn thông tin về cái chết của thành viên
                    string query = "INSERT INTO MemberDeaths (MemberID, DeathDate, CauseID, BurialPlaceID) VALUES (@MemberID, @DeathDate, @CauseID, @BurialPlaceID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MemberID", memberID);
                    command.Parameters.AddWithValue("@DeathDate", deathDate);
                    command.Parameters.AddWithValue("@CauseID", causeID);
                    command.Parameters.AddWithValue("@BurialPlaceID", burialPlaceID);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        // thêm mối quan hệ
        public bool AddRelationship(int memberID1, int memberID2, int relationshipID, DateTime eventDate)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO MemberRelationships (MemberID1, MemberID2, RelationshipID, EventDate) " +
                               "VALUES (@MemberID1, @MemberID2, @RelationshipID, @EventDate)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MemberID1", memberID1);
                command.Parameters.AddWithValue("@MemberID2", memberID2);
                command.Parameters.AddWithValue("@RelationshipID", relationshipID);
                command.Parameters.AddWithValue("@EventDate", eventDate);

                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch 
                {
                    // Log hoặc xử lý lỗi nếu cần
                    return false;
                }
            }
        }
        // Lấy danh sách quê quán
        public Dictionary<int, string> GetHometownsTitles()
        {
            Dictionary<int, string> hometowns = new Dictionary<int, string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT HometownID, HometownName FROM Hometowns";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int hometownsID = reader.GetInt32(0);
                    string title = reader.GetString(1);
                    hometowns.Add(hometownsID, title);
                }
            }
            return hometowns;
        }
        // Lấy danh sách nguyên nhân chết
        public Dictionary<int, string> GetDeathcausesTitles()
        {
            Dictionary<int, string> causes = new Dictionary<int, string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT CauseID, CauseName FROM Deathcauses";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int causesID = reader.GetInt32(0);
                    string title = reader.GetString(1);
                    causes.Add(causesID, title);
                }
            }
            return causes;
        }
        // Lấy danh sách mối quan hệ
        public Dictionary<int, string> GetRelationshipsTitles()
        {            
            Dictionary<int, string> relationships = new Dictionary<int, string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT RelationshipID, RelationshipType FROM Relationships";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int relationshipID = reader.GetInt32(0);
                    string relationshipType = reader.GetString(1);
                    relationships.Add(relationshipID, relationshipType);
                }
            }
            return relationships;
        }

        // Lấy danh sách nghề nghiệp
        public Dictionary<int, string> GetOccupationsTitles()
        {
            Dictionary<int, string> occupations = new Dictionary<int, string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT OccupationID, OccupationName FROM Occupations";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int occupationID = reader.GetInt32(0);
                    string occupationName = reader.GetString(1);
                    occupations.Add(occupationID, occupationName);
                }
            }
            return occupations;
        }

        // Lấy danh sách nơi mai táng
        public Dictionary<int, string> GetBurialPlaceTitles()
        {
            Dictionary<int, string> burialplaces = new Dictionary<int, string>();
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PlaceID, PlaceName FROM BurialPlaces";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int placeID = reader.GetInt32(0);
                    string placeName = reader.GetString(1);
                    burialplaces.Add(placeID, placeName);
                }

            }

            return burialplaces;
        }

    }
}
