using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Models;

namespace Repository.Database
{
    public class VerkiezingSQLContext : IVerkiezingsContext
    {
        private DatabaseConnection con = new DatabaseConnection();

        public void SavePartij(Partij partij)
        {
            string query = partij.ID == 0
                ? "INSERT INTO [Partij] ([Naam], [NaamVolledig], [Lijsttrekker])" +
                  "VALUES (@Naam, @NaamVolledig, @Lijsttrekker)"
                : "UPDATE [Partij] SET [Naam]=@Naam, [NaamVolledig]=@NaamVolledig, [Lijsttrekker]=@Lijsttrekker " +
                  "WHERE ID=@ID";

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Naam", partij.Naam);
                command.Parameters.AddWithValue("@NaamVolledig", partij.NaamVolledig);
                command.Parameters.AddWithValue("@Lijsttrekker", partij.Lijsttrekker);
                if (partij.ID != 0)
                {
                    command.Parameters.AddWithValue("@ID", partij.ID);
                }
                command.ExecuteNonQuery();
            }
        }

        public void DeletePartij(Partij partij)
        {
            throw new System.NotImplementedException();
        }

        public List<Partij> GetAllPartij()
        {
            string query = "SELECT * FROM [Partij] ORDER BY [Naam]";

            List<Partij> partijen = new List<Partij>();

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Partij partij = new Partij(dataReader.GetString(dataReader.GetOrdinal("Naam")),
                            dataReader.GetString(dataReader.GetOrdinal("NaamVolledig")),
                            dataReader.GetString(dataReader.GetOrdinal("Lijsttrekker")));
                        partij.SetID(dataReader.GetInt32(dataReader.GetOrdinal("ID")));
                        partijen.Add(partij);
                    }
                }
            }
            return partijen;
        }

        public void SaveVerkiezing(Verkiezing verkiezing)
        {
            string query = "INSERT INTO [Verkiezing] ([Naam], [Zetels], [ZetelsMeerderheid])" +
                           "VALUES (@Naam, @Zetels, @ZetelsMeerderheid)";

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@Naam", verkiezing.Naam);
                command.Parameters.AddWithValue("@Zetels", verkiezing.Zetels);
                command.Parameters.AddWithValue("@ZetelsMeerderheid", verkiezing.ZetelsMeerderheid);
                command.ExecuteNonQuery();
            }
        }

        public void AddPartijVerkiezing(int verkiezingID, int partijID)
        {
            string query = "INSERT INTO [Verkiezing_Partij] ([VerkiezingID], [PartijID])" +
                            "VALUES (@VerkiezingID, @PartijID)";

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@VerkiezingID", verkiezingID);
                command.Parameters.AddWithValue("@PartijID", partijID);
                command.ExecuteNonQuery();
            }
        }

        public List<Verkiezing> GetAllVerkiezingen()
        {
            string query = "SELECT * FROM [Verkiezing] ORDER BY [Naam]";

            List<Verkiezing> verkiezingen = new List<Verkiezing>();

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Verkiezing verkiezing = new Verkiezing(dataReader.GetString(dataReader.GetOrdinal("Naam")),
                            dataReader.GetInt32(dataReader.GetOrdinal("Zetels")),
                            dataReader.GetInt32(dataReader.GetOrdinal("ZetelsMeerderheid")));
                        verkiezing.SetID(dataReader.GetInt32(dataReader.GetOrdinal("ID")));
                        verkiezingen.Add(verkiezing);
                    }
                }
            }
            return verkiezingen;
        }

        public void GetVerkiezingPartijen(Verkiezing verkiezing)
        {
            string query = "SELECT p.* FROM [Partij] p " +
                           "INNER JOIN [Verkiezing_Partij] vp ON vp.[PartijID] = p.ID " +
                           "INNER JOIN [Verkiezing] v ON v.[ID] = vp.[VerkiezingID] " +
                           "WHERE v.ID = @ID " +
                           "ORDER BY p.[Naam]";
            List<Partij> partijen = new List<Partij>();

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", verkiezing.ID);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Partij partij = new Partij(dataReader.GetString(dataReader.GetOrdinal("Naam")),
                            dataReader.GetString(dataReader.GetOrdinal("NaamVolledig")),
                            dataReader.GetString(dataReader.GetOrdinal("Lijsttrekker")));
                        partij.SetID(dataReader.GetInt32(dataReader.GetOrdinal("ID")));
                        partijen.Add(partij);
                    }
                    verkiezing.SetVerkiezingPartijen(partijen);
                }
            }
        }

        public void GetVerkiezingUitslagen(Verkiezing verkiezing)
        {
            string query = "SELECT u.* FROM [Uitslag] u " +
                           "WHERE u.VerkiezingID = @ID " +
                           "ORDER BY u.[Datum] DESC";
            List<Uitslag> uitslagen = new List<Uitslag>();

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", verkiezing.ID);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Uitslag uitslag = new Uitslag(dataReader.GetString(dataReader.GetOrdinal("Naam")),
                            dataReader.GetDateTime(dataReader.GetOrdinal("Datum")));

                        uitslag.SetID(dataReader.GetInt32(dataReader.GetOrdinal("ID")));
                        uitslagen.Add(uitslag);
                    }
                    verkiezing.SetVerkiezingUitslagen(uitslagen);
                }
            }
        }

        public void SaveUitslag(Uitslag uitslag, int verkiezingID)
        {
            int uitslagID = uitslag.ID;
            string query = uitslagID == 0
                ? "INSERT INTO [Uitslag] ([VerkiezingID], [Naam], [Datum]) " +
                  "OUTPUT INSERTED.ID " +
                  "VALUES (@VerkiezingID, @Naam, @Datum)"
                : "UPDATE [Uitslag] SET [VerkiezingID]=@VerkiezingID, [Naam]=@Naam, [Datum]=@Datum " +
                  "WHERE ID=@ID";

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@VerkiezingID", verkiezingID);
                command.Parameters.AddWithValue("@Naam", uitslag.Naam);
                command.Parameters.AddWithValue("@Datum", uitslag.Datum);
                if (uitslag.ID != 0)
                {
                    command.Parameters.AddWithValue("@ID", uitslag.ID);
                    command.ExecuteNonQuery();
                }
                else
                {
                    int result = Convert.ToInt32(command.ExecuteScalar());
                    uitslag.SetID(result);
                }
            }
            foreach (Partij p in uitslag.Partijen)
            {
                query = uitslagID == 0
                    ? "INSERT INTO [Uitslag_Partij] ([UitslagID], [PartijID], [Stemmen], [Percentage], [Zetels]) " +
                      "VALUES (@UitslagID, @PartijID, @Stemmen, @Percentage, @Zetels)"
                    : "UPDATE [Uitslag_Partij] SET [Stemmen]=@Stemmen, [Percentage]=@Percentage, [Zetels]=@Zetels " +
                      "WHERE UitslagID=@UitslagID AND PartijID=@PartijID";

                using (SqlCommand command = con.Connection.CreateCommand())
                {
                    command.CommandText = query;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@Stemmen", p.Stemmen);
                    command.Parameters.AddWithValue("@Percentage", p.Percentage);
                    command.Parameters.AddWithValue("@Zetels", p.Zetels);
                    command.Parameters.AddWithValue("@UitslagID", uitslag.ID);
                    command.Parameters.AddWithValue("@PartijID", p.ID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void GetUitslagPartijen(Uitslag uitslag)
        {
            string query = "SELECT p.*, up.[Stemmen], up.[Percentage], up.[Zetels] FROM [Partij] p " +
                           "INNER JOIN [Uitslag_Partij] up ON up.[PartijID] = p.ID " +
                           "INNER JOIN [Uitslag] u ON u.[ID] = up.[UitslagID] " +
                           "WHERE u.ID = @ID " +
                           "ORDER BY p.[Naam]";
            List<Partij> partijen = new List<Partij>();

            using (SqlCommand command = con.Connection.CreateCommand())
            {
                command.CommandText = query;
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@ID", uitslag.ID);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    while (dataReader.Read())
                    {
                        Partij partij = new Partij(dataReader.GetString(dataReader.GetOrdinal("Naam")),
                            dataReader.GetString(dataReader.GetOrdinal("NaamVolledig")),
                            dataReader.GetString(dataReader.GetOrdinal("Lijsttrekker")),
                            dataReader.GetInt32(dataReader.GetOrdinal("Stemmen")),
                        dataReader.GetDecimal(dataReader.GetOrdinal("Percentage")),
                        dataReader.GetInt32(dataReader.GetOrdinal("Zetels")));
                        partij.SetID(dataReader.GetInt32(dataReader.GetOrdinal("ID")));
                        partijen.Add(partij);
                    }
                    uitslag.SetUitslagPartijen(partijen);
                }
            }
        }
    }
}