using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_final.Scripts.API
{
    class CargarAPI
    {
        public readonly HttpClient client = new HttpClient();

        public async Task<List<DatosAPI>> ObtenerAPI()
        {
            try
            {
                var json = await client.GetStringAsync(
                    "https://api.hearthstonejson.com/v1/latest/esES/cards.json"
                );

                var opciones = new JsonSerializerOptions()
                {
                    PropertyNameCaseInsensitive = true
                };

                return JsonSerializer.Deserialize<List<DatosAPI>>(json, opciones);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error API: " + ex.Message);
                return new List<DatosAPI>();
            }
        }
    }
}