using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using ModernArt.Core.Enums;
using ModernArt.Core.Model;

namespace ModernArt.Core.Negocio
{
    public static class GameHelper
    {
        private static string[] nombres = { "Ricardio", "Vicente", "Emiliano", "Felix",
                                   "Verónica", "Montserrat", "Andrea", "Olga", "Nacho", "Domingo",
                                   "César", "Agustín", "Hugo", "Tomás", "Rafael", "Donatello", "Miguel Angel",
                            "Leonardo", "Nieves", "Isabel", "Irene", "Mar", "Alicia", "Carla", "Eva",
                            "Lidia", "Aurora", "Celia", "Claudia", "Amparo", "Sebastián", "Samuel" };

        /// <summary>
        /// Obtiene lista de nombres aleatorios
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        public static IEnumerable<string> GetNombres(int numero)
        {
            var copiaNombres = nombres.ToList();
            foreach (int i in Enumerable.Range(0, numero))
            {
                string nombre = General.ElementoAleatorio(copiaNombres);
                copiaNombres.Remove(nombre);
                yield return nombre;
            }
        }

        public static IEnumerable<string> GetCiudades()
            => (new string[] { "Bilbao", "Barcelona", "New York", "Londres", "Leipzig", "Buenos Aires", "Melbourne", "Florencia" });

        public static string GradoExito(int indx) => new string[] {"Apenas mencionado", "Se empieza a hacer oir", "Moderada reputación",
        "Bastante en boga", "Éxito asegurado", "Gran repercusión"}[indx];

        public static int NumCartas(int ronda, int numJugadores)
        {
            switch (numJugadores)
            {
                case 3: return new int[] { 10, 6, 6, 0 }[ronda - 1];
                case 4: return new int[] { 9, 4, 4, 0 }[ronda - 1];
                case 5: return new int[] { 9, 4, 4, 0 }[ronda - 1];
            }
            throw new ArgumentOutOfRangeException("Numero de jugadores debe estar entre 3 y 5");
        }

        public static IEnumerable<Cuadro> GetCuadros()
        {
            string[] nombres = {"Sorpresa e incomprensión", "Traición", "Impasibilidad", "La cuadratura perpleja", "Caída al vacío", "Carrera en el Hipódromo",
               "Suspenso y repetición", "La conquista de las estrellas", "El hombre despreocupado", "Seducción", "Antimilitarismo",
               "El gran imperio del Nilo", "El efecto mariposa", "Carterista victoriano", "El presidente del gobierno", "La hora del té",
               "Bufón en mi menor", "Remordimientos", "Madam", "De vuelta al ochenta en un mundo", "El vestido azul", "Ambiguedad",
               "El significado de la locura", "Asunción y sus filtros", "Perdido en la tormenta", "El monstruo de la lluvia",
               "La rana cantaba en la cloaca", "Esplendor hilarante", "Habitantes del mar", "Sonríe y psicodeliza", "El bebé monstruo",
               "Monstruo sorprendido", "La cabra siempre tira al monte", "Dinosaurio somnoliento", "El león furioso",
               "Comadreja ladrona acechando en la noche", "Alien intimidante", "La boa", "Momento de lucidez", "Autovía", "La llave de la felicidad",
               "La cometa de los sueños", "Triangularidad, la forma perfecta", "Éxito", "Día de playa", "La queja del pollito", "Deforestación",
               "De la era del vapor a la era nuclear", "Incertidumbre", "La edad moderna", "El hombre sin escrúpulos", "El progreso se cobra su precio",
               "Molinos de viento", "Deshaucio", "Con \"K\" de Koriko", "Comunismo", "Desintegración", "Los Rapa nui", "La bailarina del fuego",
               "Lluvia sangrienta", "El círculo de la muerte", "Beso al atardecer", "El gran interrogante", "Borrón... y cuenta nueva",
               "Descuadre en el balance", "Protección", "Locura que se desvanece", "Intruso detectado", "El camino de la vida", "Súplica al cielo" };

            List<Valoracion> valoraciones = new List<Valoracion>();
            List<TipoPuja> tiposPujas = new List<TipoPuja>();

            //Nex
            valoraciones.Add(new Valoracion(3, 2, 2));
            valoraciones.Add(new Valoracion(5, 3, 3));
            valoraciones.Add(new Valoracion(2, 4, 3));
            valoraciones.Add(new Valoracion(3, 3, 2));
            valoraciones.Add(new Valoracion(3, 2, 3));
            valoraciones.Add(new Valoracion(2, 2, 4));
            valoraciones.Add(new Valoracion(3, 2, 3));
            valoraciones.Add(new Valoracion(3, 5, 3));
            valoraciones.Add(new Valoracion(1, 2, 4));
            valoraciones.Add(new Valoracion(3, 1, 5));
            valoraciones.Add(new Valoracion(4, 2, 5));
            valoraciones.Add(new Valoracion(3, 2, 3));
            tiposPujas.Add(TipoPuja.Abierta);
            tiposPujas.Add(TipoPuja.UnaVuelta);
            tiposPujas.Add(TipoPuja.Abierta);
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(TipoPuja.UnaVuelta);
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(TipoPuja.Abierta);
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(TipoPuja.UnaVuelta);
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(5));

            //Bahut
            valoraciones.Add(new Valoracion(4, 4, 2));
            valoraciones.Add(new Valoracion(3, 2, 2));
            valoraciones.Add(new Valoracion(3, 3, 2));
            valoraciones.Add(new Valoracion(2, 3, 2));
            valoraciones.Add(new Valoracion(4, 3, 4));
            valoraciones.Add(new Valoracion(5, 3, 3));
            valoraciones.Add(new Valoracion(3, 2, 5));
            valoraciones.Add(new Valoracion(4, 3, 2));
            valoraciones.Add(new Valoracion(3, 4, 2));
            valoraciones.Add(new Valoracion(4, 2, 5));
            valoraciones.Add(new Valoracion(3, 3, 3));
            valoraciones.Add(new Valoracion(4, 3, 3));
            valoraciones.Add(new Valoracion(3, 3, 2));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(4));

            //Darmoir
            valoraciones.Add(new Valoracion(4, 2, 3));
            valoraciones.Add(new Valoracion(3, 2, 3));
            valoraciones.Add(new Valoracion(4, 3, 2));
            valoraciones.Add(new Valoracion(2, 2, 4));
            valoraciones.Add(new Valoracion(3, 3, 3));
            valoraciones.Add(new Valoracion(4, 3, 4));
            valoraciones.Add(new Valoracion(5, 2, 3));
            valoraciones.Add(new Valoracion(3, 3, 3));
            valoraciones.Add(new Valoracion(4, 3, 4));
            valoraciones.Add(new Valoracion(5, 2, 3));
            valoraciones.Add(new Valoracion(4, 3, 3));
            valoraciones.Add(new Valoracion(3, 2, 3));
            valoraciones.Add(new Valoracion(4, 2, 2));
            valoraciones.Add(new Valoracion(3, 5, 3));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(5));

            //Sadland
            valoraciones.Add(new Valoracion(3, 3, 2));
            valoraciones.Add(new Valoracion(4, 2, 4));
            valoraciones.Add(new Valoracion(4, 3, 3));
            valoraciones.Add(new Valoracion(1, 3, 2));
            valoraciones.Add(new Valoracion(3, 4, 1));
            valoraciones.Add(new Valoracion(2, 3, 2));
            valoraciones.Add(new Valoracion(4, 1, 4));
            valoraciones.Add(new Valoracion(5, 1, 4));
            valoraciones.Add(new Valoracion(3, 2, 5));
            valoraciones.Add(new Valoracion(2, 2, 2));
            valoraciones.Add(new Valoracion(5, 1, 4));
            valoraciones.Add(new Valoracion(3, 3, 5));
            valoraciones.Add(new Valoracion(3, 1, 5));
            valoraciones.Add(new Valoracion(3, 2, 4));
            valoraciones.Add(new Valoracion(1, 4, 5));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(1));

            //Koriko
            valoraciones.Add(new Valoracion(3, 4, 2));
            valoraciones.Add(new Valoracion(3, 3, 5));
            valoraciones.Add(new Valoracion(4, 3, 3));
            valoraciones.Add(new Valoracion(4, 3, 2));
            valoraciones.Add(new Valoracion(4, 4, 2));
            valoraciones.Add(new Valoracion(3, 2, 5));
            valoraciones.Add(new Valoracion(4, 2, 2));
            valoraciones.Add(new Valoracion(5, 2, 4));
            valoraciones.Add(new Valoracion(4, 2, 2));
            valoraciones.Add(new Valoracion(2, 3, 2));
            valoraciones.Add(new Valoracion(1, 3, 3));
            valoraciones.Add(new Valoracion(4, 1, 2));
            valoraciones.Add(new Valoracion(2, 2, 2));
            valoraciones.Add(new Valoracion(2, 1, 3));
            valoraciones.Add(new Valoracion(3, 2, 3));
            valoraciones.Add(new Valoracion(4, 2, 2));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(3));
            tiposPujas.Add(new TipoPuja(4));
            tiposPujas.Add(new TipoPuja(2));
            tiposPujas.Add(new TipoPuja(5));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(1));
            tiposPujas.Add(new TipoPuja(1));


            List<Cuadro> cuads = new List<Cuadro>();

            int[] numCuadros = { 12, 13, 14, 15, 16 };
            int generalCont = 0;
            for (int i = 1; i <= numCuadros.Length; i++)
            {
                int idCuadro = 1;
                for (int j = 1; j <= numCuadros[i - 1]; j++)
                {
                    Valoracion val = new Valoracion(0, 0, 0);
                    cuads.Add(new Cuadro(idCuadro, nombres[generalCont], new Autor(i), tiposPujas[generalCont], valoraciones[generalCont]));
                    idCuadro++;
                    generalCont++;
                }
            }
            return cuads;
        }

        /// <summary>
        /// Sortea el jugador inicial de la partida
        /// </summary>
        /// <param name="numjugadores"></param>
        /// <returns></returns>
        public static int PrepararJugadorInicial(int numJugadores) => General.NumAleatorio(0, numJugadores - 1);
        
        #region Ficheros

        //public static List<Record> LeerBestScores()
        //{
        //    string ruta = Properties.Resources.BestScorePath;

        //    try
        //    {
        //        FileStream fs = new FileStream(ruta, FileMode.Open);
        //        BinaryFormatter binForm = new BinaryFormatter();
        //        List<Record> lista = (List<Record>)binForm.Deserialize(fs);
        //        fs.Close();
        //        return lista;
        //    }
        //    catch (FileNotFoundException)
        //    {
        //        return new List<Record>();
        //    }
        //}

        //public static void GuardarPuntuacion(Record score)
        //{
        //    var scores = LeerBestScores();
        //    scores.Add(score);
        //    FileStream fs = new FileStream(Properties.Resources.BestScorePath, FileMode.Create);
        //    BinaryFormatter binForm = new BinaryFormatter();
        //    binForm.Serialize(fs, scores);
        //    fs.Close();
        //}

        #endregion
    }
}