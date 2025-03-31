using System.Net;
using System.Text;

namespace AlmoxafiradoFront.Controllers
{
    internal class StringContext : HttpContent
    {
        private object categoriaSerializada;
        private Encoding uTF8;
        private string v;

        public StringContext(object categoriaSerializada, Encoding uTF8, string v)
        {
            this.categoriaSerializada = categoriaSerializada;
            this.uTF8 = uTF8;
            this.v = v;
        }

        protected override Task SerializeToStreamAsync(Stream stream, TransportContext? context)
        {
            throw new NotImplementedException();
        }

        protected override bool TryComputeLength(out long length)
        {
            throw new NotImplementedException();
        }
    }
}