namespace BolsaDeEmpleo
{
    //Conexion SQL 
    public class Conexion_Basica
    {
        private string string_conexion = "server=DESKTOP-D1091LH\\DEV;database=db_facturas;IntegratedSecurity=True;TrustServer=True";
    }


    //Clase Empresas
    public class Empresas
    {
        //atributos propios y privados
        private int Id = 0;
        private int Cod_Empresa = 0;
        private String Nombre = "";
        private String? Direccion = null;

        //Metodo constructor vacio
        public Empresas()
        {

        }

        //metodo constructor parametrizado
        public Empresas(int id, int codEmp, String nom, String dir)
        {
            this.Id = id;
            this.Cod_Empresa = codEmp;
            this.Nombre = nom;
            this.Direccion = dir;
        }

        //metodos 
        public void CrearVacantes()
        {

        }

        //metodos getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public int cod_empresa { get => this.Cod_Empresa; set => this.Cod_Empresa = value; }
        public String nombre { get => this.Nombre; set => this.Nombre = value; }
        public String direccion { get => this.Direccion; set => this.Direccion = value; }

    } //Fin Empresas

    //Clase Vacantes
    public class Vacantes
    {
        //atributos propios y privados
        private int Id = 0;
        private Empresas Empresa = new Empresas();
        private Cargos Cargo = new Cargos();
        private Boolean Disponibilidad = false;
        private List<Postulaciones> ListaPostulaciones = new List<Postulaciones>();

        //metodo constructor
        public Vacantes()
        {

        }

        //metodo constructor parametrizado
        public Vacantes(int id, Empresas empre, Cargos carg, Boolean act, List<Postulaciones> Lpostul)
        {
            this.Id = id;
            this.Empresa = empre;
            this.Cargo = carg;
            this.Disponibilidad = act;
            this.ListaPostulaciones = Lpostul;
        }

        //metodos vacantes
        public void ActualizarDisponibilidad()
        {

        }

        public void MostrarPostulaciones()
        {

        }

        //metodos getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public Empresas empresa { get => this.Empresa; set => this.Empresa = value; }
        public Cargos cargo { get => this.Cargo; set => this.Cargo = value; }
        public Boolean disponibilidad { get => this.Disponibilidad; set => this.Disponibilidad = value; }
        public List<Postulaciones> postulacion { get => this.ListaPostulaciones; set => this.ListaPostulaciones = value; }


    }//Fin Vacantes

    //Clase Postulaciones 
    public class Postulaciones
    {
        private int Id = 0;
        private Vacantes Vacante = new Vacantes();
        private Personas Persona = new Personas();
        private Boolean Elegido = false;


        //Metodo constructor vacio
        public Postulaciones()
        {

        }

        //metodo constructor parametrizado
        public Postulaciones(int id, Vacantes vac, Personas per, Boolean Eleg)
        {
            this.Id = id;
            this.Vacante = vac;
            this.Persona = per;
            this.Elegido = Eleg;
        }

        //metodos
        public void ActualizarElegido()
        {

        }

        //getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public Vacantes vacante { get => this.Vacante; set => this.Vacante = value; }
        public Personas personas { get => this.Persona; set => this.Persona = value; }
        public Boolean elegido { get => this.Elegido; set => this.Elegido = value; }
    } //Fin Postulaciones

    //Clase Personas
    public class Personas
    {
        private int Id = 0;
        private String Cedula = "";
        private String Nombre = "";
        private String? Direccion = null;


        //Metodo constructor vacio
        public Personas()
        {

        }

        //metodo constructor parametrizado
        public Personas(int id, String ced, String nom, String dir)
        {
            this.Id = id;
            this.Cedula = ced;
            this.Nombre = nom;
            this.Direccion = dir;
        }

        //getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public String cedula { get => this.Cedula; set => this.Cedula = value; }
        public String nombre { get => this.Nombre; set => this.Nombre = value; }
        public String direccion { get => this.Direccion; set => this.Direccion = value; }
    } //Fin Personas

    //Clase Estudios
    public class Estudios
    {
        private int Id = 0;
        private int Cod_Estudio = 0;
        private String Nombre = "";

        //metodo constructor vacio
        public Estudios()
        {

        }

        //metodo constructor parametrizado
        public Estudios(int id, int codEst, string nom)
        {
            this.Id = id;
            this.Cod_Estudio = codEst;
            this.Nombre = nom;
        }
        //metodos getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public int cod_estudio { get => this.Cod_Estudio; set => this.Cod_Estudio = value; }
        public string nombre { get => this.Nombre; set => this.Nombre = value; }
    } //Fin Estudios

    //Clase Cargos
    public class Cargos
    {
        //atributos propios y privados
        private int Id = 0;
        private String Nombre = "";


        //Método constructor vacio
        public Cargos()
        {

        }

        //metodo constructor parametrizado
        public Cargos(int id, String nom)
        {
            this.Id = id;
            this.Nombre = nom;
        }

        //Getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public String nombre { get => this.Nombre; set => this.Nombre = value; }
    } // Fin Cargos

    //Clase Personas_Estudios
    public class Personas_Estudios
    {
        //atributos propios y privados
        private int Id = 0;
        private Personas Persona = new Personas();
        private Estudios Estudio = new Estudios();

        //Método constructor vacio
        public Personas_Estudios()
        {

        }

        //metodo constructor parametrizado
        public Personas_Estudios(int id, Personas person, Estudios estud)
        {
            this.Id = id;
            this.Persona = person;
            this.Estudio = estud;
        }

        //Getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public Personas persona { get => this.Persona; set => this.Persona = value; }
        public Estudios estudio { get => this.Estudio; set => this.Estudio = value; }
    } //Fin Personas_Estudios



    //Clase Cargos-Estudios
    public class Cargos_Estudios
    {
        //atributos
        private int Id = 0;
        private Cargos Cargo = new Cargos();
        private Estudios Estudio = new Estudios();

        //Método constructor vacio
        public Cargos_Estudios()
        {

        }

        //metodo constructor parametrizado
        public Cargos_Estudios(int id, Cargos carg, Estudios estu)
        {
            this.Id = id;
            this.Cargo = carg;
            this.Estudio = estu;
        }

        //Getters y setters
        public int id { get => this.Id; set => this.Id = value; }
        public Cargos cargo { get => this.Cargo; set => this.Cargo = value; }
        public Estudios estudio { get => this.Estudio; set => this.Estudio = value; }
    } //Fin Cargos-Estudios



}