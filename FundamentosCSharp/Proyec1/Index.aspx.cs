using Proyec1.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyec1
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarMensaje();
        }
        public void mostrarMensaje() 
        {
            //Crear un objeto de Car 
            Car objCar = new Car();
            string msj = objCar.stop();
            LblMensaje.Text = msj;

        }
    }
}