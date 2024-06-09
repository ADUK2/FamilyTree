using FamilyTree.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTree.Classes
{
    public class Member
    {
        private string connectionString = "Data Source=WIN-124DGHNTBQA;Initial Catalog=FamilyTreeDB;Integrated Security=True";

        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hometown { get; set; }
        public string Occupation { get; set; }
        public string Address { get; set; }

        public int AddMember(string fullName, string gender, DateTime birthDate, string address, int occupationID, int hometownID, bool isRoot)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Members (FullName, Gender, BirthDate, Address, OccupationID, HometownID, isRoot) " +
                               "VALUES (@FullName, @Gender, @BirthDate, @Address, @OccupationID, @HometownID, @isRoot); " +
                               "SELECT CAST(scope_identity() AS int)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FullName", fullName);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@OccupationID", occupationID);
                command.Parameters.AddWithValue("@HometownID", hometownID);
                command.Parameters.AddWithValue("@isRoot", isRoot);

                int newMemberID = (int)command.ExecuteScalar();
                return newMemberID;
            }
        }

        public void UpdateMember(int id, string name, string gender, DateTime birthDate, string hometown, string occupation, string address)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Members SET Name = @Name, Gender = @Gender, BirthDate = @BirthDate, Hometown = @Hometown, Occupation = @Occupation, Address = @Address WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@BirthDate", birthDate);
                command.Parameters.AddWithValue("@Hometown", hometown);
                command.Parameters.AddWithValue("@Occupation", occupation);
                command.Parameters.AddWithValue("@Address", address);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteMember(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Members WHERE ID = @ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);
                command.ExecuteNonQuery();
            }
        }
        // Lấy danh sách thành viên
        public List<Member> GetAllMembers()
        {
            List<Member> members = new List<Member>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT MemberID, FullName, Gender, BirthDate, HometownID, OccupationID, Address FROM Members";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(new Member
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Gender = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        BirthDate = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                        Hometown = reader.IsDBNull(4) ? string.Empty : reader.GetInt32(4).ToString(),
                        Occupation = reader.IsDBNull(5) ? string.Empty : reader.GetInt32(5).ToString(),
                        Address = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
                    });
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
                string query = "SELECT MemberID, FullName, Gender, BirthDate, HometownID, OccupationID, Address FROM Members WHERE isRoot = 1";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    members.Add(new Member
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Gender = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        BirthDate = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                        Hometown = reader.IsDBNull(4) ? string.Empty : reader.GetInt32(4).ToString(),
                        Occupation = reader.IsDBNull(5) ? string.Empty : reader.GetInt32(5).ToString(),
                        Address = reader.IsDBNull(6) ? string.Empty : reader.GetString(6)
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
        public bool AddAchievement(int memberID, int achievementID, DateTime achievementDate)
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
        public bool AddMemberDeath(int memberID, DateTime deathDate, int causeID, int burialPlaceID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    /*// Kiểm tra xem memberID có tồn tại không
                    string checkMemberQuery = "SELECT COUNT(*) FROM Members WHERE ID = @MemberID";
                    SqlCommand checkMemberCommand = new SqlCommand(checkMemberQuery, connection);
                    checkMemberCommand.Parameters.AddWithValue("@MemberID", memberID);
                    int memberCount = (int)checkMemberCommand.ExecuteScalar();
                    if (memberCount == 0)
                    {
                        throw new Exception("Member ID does not exist.");
                    }

                    // Kiểm tra xem CauseID có hợp lệ không
                    string checkCauseQuery = "SELECT COUNT(*) FROM Causes WHERE ID = @CauseID";
                    SqlCommand checkCauseCommand = new SqlCommand(checkCauseQuery, connection);
                    checkCauseCommand.Parameters.AddWithValue("@CauseID", causeID);
                    int causeCount = (int)checkCauseCommand.ExecuteScalar();
                    if (causeCount == 0)
                    {
                        throw new Exception("Cause ID is not valid.");
                    }

                    // Kiểm tra xem BurialPlaceID có hợp lệ không
                    string checkBurialPlaceQuery = "SELECT COUNT(*) FROM BurialPlaces WHERE ID = @BurialPlaceID";
                    SqlCommand checkBurialPlaceCommand = new SqlCommand(checkBurialPlaceQuery, connection);
                    checkBurialPlaceCommand.Parameters.AddWithValue("@BurialPlaceID", burialPlaceID);
                    int burialPlaceCount = (int)checkBurialPlaceCommand.ExecuteScalar();
                    if (burialPlaceCount == 0)
                    {
                        throw new Exception("Burial Place ID is not valid.");
                    }

                    // Kiểm tra xem DeathDate có sau ngày sinh không
                    string checkBirthDateQuery = "SELECT DateOfBirth FROM Members WHERE ID = @MemberID";
                    SqlCommand checkBirthDateCommand = new SqlCommand(checkBirthDateQuery, connection);
                    checkBirthDateCommand.Parameters.AddWithValue("@MemberID", memberID);
                    DateTime birthDate = (DateTime)checkBirthDateCommand.ExecuteScalar();
                    if (deathDate <= birthDate)
                    {
                        throw new Exception("Death date must be after the birth date.");
                    }*/

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
                catch (Exception ex)
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
