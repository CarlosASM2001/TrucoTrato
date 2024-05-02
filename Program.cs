using J3QQ4;
using System.Text;

namespace TrucoTrato
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=Encoding.UTF8;
            Persona[] personas =
            {
                new Persona(35, "Brais", 177, "trick"),
                new Persona(22, "Carlos", 175, "trick"),
                new Persona(5, "Pedro", 80, "treat"),
                new Persona(10, "Victoria", 150, "treat")
            };


            Halloween(personas);
            
        }




        static void Halloween(Persona[] persona)
        {
            String[] scares = [Emoji.Jack_O_Lantern, Emoji.Ghost, Emoji.Skull, Emoji.Space_Invader];
            String[] candies = [Emoji.Cake, Emoji.Candy, Emoji.Cookie, Emoji.Lollipop];

            Random rand = new Random();


            foreach (Persona person in persona)
            {
                string resultadoNombreTrick= null;
                string resultadoEdadTrick = null;
                string resultadoAlturaTrick = null;

                string resultadoNombreTreat = null;
                string resultadoEdadTreat = null;
                string resultadoAlturaTreat = null;

                if (person.getTipo().Equals("TRICK"))
                {

                    resultadoNombreTrick = SustoPersonaNombre(person, scares, rand);
                    
                    

                    if(person.getEdad() % 2 == 0)
                    {
                        resultadoEdadTrick += scares[rand.Next(scares.Length)];
                        resultadoEdadTrick += scares[rand.Next(scares.Length)];

                    }

                    int heigtAux = person.getAltura();
                    while ( heigtAux >= 100)
                    {
                        resultadoAlturaTrick += scares[rand.Next(scares.Length)];
                        resultadoAlturaTrick += scares[rand.Next(scares.Length)];
                        resultadoAlturaTrick += scares[rand.Next(scares.Length)];

                        heigtAux -= 100;
                    }

                    Console.WriteLine("PERSONA TRICK");
                    Console.WriteLine(resultadoNombreTrick);
                    Console.WriteLine(resultadoNombreTrick);
                    Console.WriteLine(resultadoEdadTrick);
                }
                else
                {

                    resultadoNombreTreat=DulcePersonaNombre(person,candies, rand);

                    int edadAux= person.getEdad();
                    if(person.getEdad() <= 10)
                    {
                        while (edadAux >= 3)
                        {
                            resultadoEdadTreat += candies[rand.Next(candies.Length)];
                            edadAux -= 3;
                        }
                    }

                    int alturaAux=person.getAltura();
                    if (person.getAltura() <= 150)
                    {
                        while(alturaAux >= 50)
                        {
                            resultadoAlturaTreat += candies[rand.Next(candies.Length)];
                            resultadoAlturaTreat += candies[rand.Next(candies.Length)];

                            alturaAux -= 50;
                        }

                    }

                    Console.WriteLine("PERSONA TREAT");
                    Console.WriteLine(resultadoNombreTreat);
                    Console.WriteLine(resultadoNombreTreat);
                    Console.WriteLine(resultadoEdadTreat);

                }



                
            }
           
        } 




        static string DulcePersonaNombre(Persona persona, string[] candies, Random rand)
        {
            string result = null;

            for (int i = 0; i < persona.getNombre().Length; i++)
            {
                result += candies[rand.Next(candies.Length)];
            }

            return result;
        }


        static string SustoPersonaNombre(Persona persona, string[] scares, Random rand)
        {
            string result=null;
            

            for (int i = 0;i<persona.getNombre().Length;i+=2)
            {
                if(i+1< persona.getNombre().Length)
                {
                    result += scares[rand.Next(scares.Length)];
                }
            }


            return result;


        }



        


    }
}
