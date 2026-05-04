using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_5
{
    /// <summary>
    /// 
    /// </summary>
    public class Porra
    {
        /// <summary>
        /// The izena
        /// </summary>
        private string izena, irabazlea, finalista, goleatzailea;
        /// <summary>
        /// The puntuak
        /// </summary>
        private int puntuak;

        /// <summary>
        /// Gets or sets the izena.
        /// </summary>
        /// <value>
        /// The izena.
        /// </value>
        public string Izena { get => izena; set => izena = value; }
        /// <summary>
        /// Gets or sets the irabazlea.
        /// </summary>
        /// <value>
        /// The irabazlea.
        /// </value>
        public string Irabazlea { get => irabazlea; set => irabazlea = value; }
        /// <summary>
        /// Gets or sets the finalista.
        /// </summary>
        /// <value>
        /// The finalista.
        /// </value>
        public string Finalista { get => finalista; set => finalista = value; }
        /// <summary>
        /// Gets or sets the goleatzailea.
        /// </summary>
        /// <value>
        /// The goleatzailea.
        /// </value>
        public string Goleatzailea { get => goleatzailea; set => goleatzailea = value; }

        /// <summary>
        /// Gets or sets the puntuak.
        /// </summary>
        /// <value>
        /// The puntuak.
        /// </value>
        public int Puntuak { get => puntuak; set => puntuak = value; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Porra"/> class.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <param name="ir">The ir.</param>
        /// <param name="fi">The fi.</param>
        /// <param name="go">The go.</param>
        /// <param name="p">The p.</param>
        public Porra(string i, string ir, string fi, string go, int p) {
            this.izena = i;
            this.irabazlea = ir;
            this.finalista = fi;
            this.goleatzailea= go;
            this.puntuak= p;    
        }

        /// <summary>
        /// Pantailaratus this instance.
        /// </summary>
        /// <returns></returns>
        public string Pantailaratu()
        {
            return "TALDEA=" + izena + ", bere IRABAZLEA=" + irabazlea + ", beste FINALISTA=" + finalista + ", GOLEATZAILEA=" + goleatzailea + " eta PUNTUAK=" + puntuak;

        }
        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return izena+"-"+irabazlea+"-"+finalista+"-"+goleatzailea+"-"+puntuak;
        }
        /// <summary>
        /// Asmatus the irabazlea.
        /// </summary>
        /// <returns></returns>
        public int AsmatuIrabazlea()
        {
            return (puntuak + 25);
        }
        /// <summary>
        /// Asmatus the bi finalistak.
        /// </summary>
        /// <returns></returns>
        public int AsmatuBiFinalistak()
        {
            return (puntuak + 20);
        }
        /// <summary>
        /// Golekoes this instance.
        /// </summary>
        /// <returns></returns>
        public int Goleko()
        {
            return (puntuak + 3);
        }

    }
}
