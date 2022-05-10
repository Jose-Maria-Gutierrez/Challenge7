using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidTest
{
    internal class ArchivoBinario : Archivo
    {
        private FileStream fs;
        private BinaryWriter bw;
        public ArchivoBinario(string nombreArchivo) : base(nombreArchivo)
        {
            this.fs = new FileStream(nombreArchivo,FileMode.OpenOrCreate,FileAccess.Write);
            this.bw = new BinaryWriter(this.fs);
        }

        public override void escribir(List<string> lista)
        {
            foreach (string str in lista)
            {
                bw.Write(str);
                bw.Write("\n");
            }
        }

        public override void cerrar()
        {
            this.fs.Close();
            this.bw.Close();
        }
    }
}
