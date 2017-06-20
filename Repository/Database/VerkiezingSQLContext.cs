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
            throw new System.NotImplementedException();
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

        public void SaveUitslag(Uitslag uitslag)
        {
            throw new System.NotImplementedException();
        }

        public Uitslag GetUitslag(Verkiezing verkiezing)
        {
            throw new System.NotImplementedException();
        }

        public void SaveCoalitie(Coalitie coalitie)
        {
            throw new System.NotImplementedException();
        }
    }
}