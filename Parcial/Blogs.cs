using System.Collections.Generic;
using System.Text;
using Parcial;

namespace Parcial
{
    public abstract class Blogs : Users
    {
       

        public abstract int BlogID { get; set; }
        public abstract string NameBlog { get; set; }
        public int CodigoUsuario { get => id; set => id = value; }
        public Blogs(int id, string nombres, string apellidos) : base(id, nombres, apellidos)
        {
        }

        //public Blogs(int BlogID, string NameBlog, int CodigoUsuario, )
        //{
        //    this.BlogID = BlogID;
        //    this.NameBlog = NameBlog;
        //    this.CodigoUsuario = CodigoUsuario;
            
        //}

    }


}