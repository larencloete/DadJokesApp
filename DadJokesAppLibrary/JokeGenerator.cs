using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DadJokesLibrary
{
    public class JokeGenerator
    {
       public static async Task<string> GetRandomJokeAsync()
        {
            HttpClient httpClient = new HttpClient();
            String dj = await httpClient.GetStringAsync("https://icanhazdadjoke.com/slack");

              Gag gag = JsonConvert.DeserializeObject<Gag>(dj);
              string returnString = string.Empty;
              
              for(int index=0; index < gag.attachments.Count;index++)
              {
                returnString = gag.attachments[index].text;

              }

            return returnString;

            //Console.WriteLine("Happiness;)");


        }



    }

}
