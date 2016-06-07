using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Generar_Publicación
{
    public partial class Form11 : Form
    {
        private Button changeItemBtn = new Button();
        private DataGridView customersDataGridView = new DataGridView();

        private BindingSource customersBindingSource = new BindingSource();


        public Form11()
        {
            InitializeComponent();
            this.changeItemBtn.Text = "Change Item";
            this.changeItemBtn.Dock = DockStyle.Bottom;
            this.changeItemBtn.Click += new EventHandler(changeItemBtn_Click);
            this.Controls.Add(this.changeItemBtn);

            customersDataGridView.Dock = DockStyle.Top;
            this.Controls.Add(customersDataGridView);
            this.Size = new Size(800, 200);
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<GrillaPublicacion> customerList = new List<GrillaPublicacion>();
            ClienteDaoImpl usrImpl = new ClienteDaoImpl();
            Cliente usr = usrImpl.GetUsuarioById(1);

            PublicacionSubastaDaoImpl publicacionSubastaDaoImpl = new PublicacionSubastaDaoImpl();
            PublicacionNormalDaoImpl publicacionNormalDaoImpl = new PublicacionNormalDaoImpl();

            IList<PublicacionSubasta> pubSubLts = publicacionSubastaDaoImpl.GetPublicacionByUsuario(usr);
            IList<PublicacionNormal> pubNorLts = publicacionNormalDaoImpl.GetPublicacionByUsuario(usr);

            foreach (PublicacionSubasta pubSubasta in pubSubLts)
            {
                GrillaPublicacion nuevoReg = new GrillaPublicacion();
                nuevoReg.idPublicacion = pubSubasta.idPublicacion;
                nuevoReg.codigo = pubSubasta.codigoPublicacion;
                nuevoReg.descProducto = pubSubasta.descripcion;
                //nuevoReg.estado = pubSubasta.EstadoPublicacion.nombre;
                //nuevoReg.rubro = pubSubasta.RubroLst.First().descripcion;
                nuevoReg.fechaInicio = pubSubasta.fechaCreacion;
                nuevoReg.fechaVencimiento = pubSubasta.fechaVencimiento;
                customerList.Add(nuevoReg);
            }


            foreach (PublicacionNormal pubNormal in pubNorLts)
            {
                GrillaPublicacion nuevoReg = new GrillaPublicacion();
                nuevoReg.idPublicacion = pubNormal.idPublicacion;
                nuevoReg.codigo = pubNormal.codigoPublicacion;
                nuevoReg.descProducto = pubNormal.descripcion;
                //nuevoReg.estado = pubNormal.EstadoPublicacion.nombre;
                //nuevoReg.rubro = pubNormal.RubroLst.First().descripcion;
                nuevoReg.fechaInicio = pubNormal.fechaCreacion;
                nuevoReg.fechaVencimiento = pubNormal.fechaVencimiento;
                customerList.Add(nuevoReg);
            }

            this.customersBindingSource.DataSource = customerList;
            this.customersDataGridView.DataSource = this.customersBindingSource;
        }

        void changeItemBtn_Click(object sender, EventArgs e)
        {
            List<Employee> customerList = this.customersBindingSource.DataSource as List<Employee>;
            customerList[0].CompanyName = "Abc";
            this.customersBindingSource.ResetItem(0);
        }

        public class Employee
        {
            private Guid idValue = Guid.NewGuid();
            private string employeeName = String.Empty;
            private string companyNameValue = String.Empty;
            private string phoneNumberValue = String.Empty;

            private Employee()
            {
                employeeName = "no data";
                companyNameValue = "no data";
                phoneNumberValue = "no data";
            }

            public static Employee CreateNewEmployee()
            {
                return new Employee();
            }

            public Guid ID
            {
                get
                {
                    return this.idValue;
                }
            }

            public string CompanyName
            {
                get
                {
                    return this.companyNameValue;
                }

                set
                {
                    this.companyNameValue = value;
                }
            }

            public string PhoneNumber
            {
                get
                {
                    return this.phoneNumberValue;
                }

                set
                {
                    this.phoneNumberValue = value;
                }
            }
        }
    }
}
