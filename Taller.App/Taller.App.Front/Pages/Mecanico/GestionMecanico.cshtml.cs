using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Taller.App.Front.Pages
{
    public class GestionMecanicoModel : PageModel
    {

        public string titulo { get; set; } = "El señor vera";

        public List<Mecani> listaMecanicos = new List<Mecani>() {
            new Mecani(){nombre = "David Rivera", especialidad = "Electricista", ciudad = "Barranquilla"},
            new Mecani(){nombre = "David Pérez", especialidad = "Latonero", ciudad = "Manizales"}
        };

        public void OnGet()
        {
            titulo = "El Señor Perez";
            this.listaMecanicos.Add(new Mecani() { nombre = "David Pérez", especialidad = "Latonero", ciudad = "Manizales" });
        }
    }

    public class Mecani
    {
        public string nombre { get; set; }
        public string especialidad { get; set; }
        public string ciudad { get; set; }

        public Mecani()
        {
        }
    }

}
