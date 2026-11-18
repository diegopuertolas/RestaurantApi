using Microsoft.Data.SqlClient;

namespace RestauranteAPI.Repositories;

public class BebidaRepository : IBebidaRepository
{
    private readonly string _connectionString;

    public BebidaRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<List<Bebida>> GetAllAsync()
    {
        var bebidas = new List<Bebida>();

        using (var connection = new SqlConnection(_connectionString))
        {
            await connection.OpenAsync();

            string query = "SELECT Nombre, Precio, EsAlcoholica FROM Bebidas";

            using (var command = new SqlCommand(query, connection))
            {
                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var bebida = new Bebida
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Precio = (double) reader.GetDecimal(2),
                            EsAlcoholica = reader.GetBoolean(3)
                        };

                        bebidas.Add(bebida);
                    }
                } 
            }
        }
        return bebidas;
    }

}