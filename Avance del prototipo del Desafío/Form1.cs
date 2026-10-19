namespace Avance_del_prototipo_del_Desafío
{
    public partial class Form1 : Form
    {
        // Arreglos: cada uno guarda un dato de hasta 100 documentos
        string[] codigos = new string[100];
        string[] nombres = new string[100];
        string[] dnis = new string[100];
        string[] telefonos = new string[100];
        string[] tipos = new string[100];
        string[] asuntos = new string[100];
        string[] fechas = new string[100];
        string[] estados = new string[100];

        // cantidad = cuantos documentos hay registrados
        int cantidad = 0;
        public Form1()
        {
            InitializeComponent();

            CargarArchivo();
            MostrarDocumento();
        }
        void LimpiarCampos()
        {
            txtNombre.Clear();
            txtDNI.Clear();
            txtTelefono.Clear();
            txtAsunto.Clear();
            txtFecha.Clear();
            cmbTipo.SelectedIndex = -1;
        }

        void RegistrarDocumento()
        {
            if (ValidarDatos() == true)
            {
                codigos[cantidad] = GenerarCodigo(cantidad + 1);
                nombres[cantidad] = txtNombre.Text;
                dnis[cantidad] = txtDNI.Text;
                telefonos[cantidad] = txtTelefono.Text;
                tipos[cantidad] = cmbTipo.Text;
                asuntos[cantidad] = txtAsunto.Text;
                fechas[cantidad] = txtFecha.Text;
                estados[cantidad] = "Pendiente";

                MessageBox.Show("Documento registrado: " + codigos[cantidad]);

                cantidad = cantidad + 1;

                GuardarArchivo();
                MostrarDocumento();
                LimpiarCampos();
            }
        }

        void ActualizarEstado()
        {
            int posicion = BuscarDocumento();

            if (posicion == -1)
            {
                MessageBox.Show("Documento no encontrado");
            }
            else if (cmbEstado.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un estado");
            }
            else
            {
                estados[posicion] = cmbEstado.Text;

                GuardarArchivo();
                MostrarDocumento();

                MessageBox.Show("Estado actualizado");
            }
        }

        void OrdenarDocumentos()
        {
            string aux;

            // Metodo burbuja: ordena por codigo
            for (int i = 0; i < cantidad - 1; i++)
            {
                for (int j = 0; j < cantidad - 1 - i; j++)
                {
                    if (codigos[j].CompareTo(codigos[j + 1]) > 0)
                    {
                        aux = codigos[j];
                        codigos[j] = codigos[j + 1];
                        codigos[j + 1] = aux;

                        aux = nombres[j];
                        nombres[j] = nombres[j + 1];
                        nombres[j + 1] = aux;

                        aux = dnis[j];
                        dnis[j] = dnis[j + 1];
                        dnis[j + 1] = aux;

                        aux = telefonos[j];
                        telefonos[j] = telefonos[j + 1];
                        telefonos[j + 1] = aux;

                        aux = tipos[j];
                        tipos[j] = tipos[j + 1];
                        tipos[j + 1] = aux;

                        aux = asuntos[j];
                        asuntos[j] = asuntos[j + 1];
                        asuntos[j + 1] = aux;

                        aux = fechas[j];
                        fechas[j] = fechas[j + 1];
                        fechas[j + 1] = aux;

                        aux = estados[j];
                        estados[j] = estados[j + 1];
                        estados[j + 1] = aux;
                    }
                }
            }
            MostrarDocumento();
        }

        void MostrarDocumento()
        {
            dgvDocumentos.Rows.Clear();

            for (int i = 0; i < cantidad; i++)
            {
                dgvDocumentos.Rows.Add(codigos[i],
                                      nombres[i],
                                      dnis[i],
                                      telefonos[i],
                                      tipos[i],
                                      asuntos[i],
                                      fechas[i],
                                      estados[i]);
            }
        }

        void GuardarArchivo()
        {
            StreamWriter escritor = new StreamWriter("expedientes.txt");

            for (int i = 0; i < cantidad; i++)
            {
                escritor.WriteLine(codigos[i]);
                escritor.WriteLine(nombres[i]);
                escritor.WriteLine(dnis[i]);
                escritor.WriteLine(telefonos[i]);
                escritor.WriteLine(tipos[i]);
                escritor.WriteLine(asuntos[i]);
                escritor.WriteLine(fechas[i]);
                escritor.WriteLine(estados[i]);
            }

            escritor.Close();
        }

        void CargarArchivo()
        {
            if (File.Exists("expedientes.txt"))
            {
                StreamReader lector = new StreamReader("expedientes.txt");

                while (lector.EndOfStream == false && cantidad < 100)
                {
                    codigos[cantidad] = lector.ReadLine() ?? "";
                    nombres[cantidad] = lector.ReadLine() ?? "";
                    dnis[cantidad] = lector.ReadLine() ?? "";
                    telefonos[cantidad] = lector.ReadLine() ?? "";
                    tipos[cantidad] = lector.ReadLine() ?? "";
                    asuntos[cantidad] = lector.ReadLine() ?? "";
                    fechas[cantidad] = lector.ReadLine() ?? "";
                    estados[cantidad] = lector.ReadLine() ?? "";
                    cantidad = cantidad + 1;
                }

                lector.Close();
            }
        }
        //Funciones

        // Revisa que un texto tenga solo numeros
        bool SoloNumeros(string texto)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] < '0' || texto[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        // Devuelve true si todos los datos estan correctos
        bool ValidarDatos()
        {
            // 1. Verificar campos vacios
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtAsunto.Text) ||
                string.IsNullOrWhiteSpace(txtFecha.Text) ||
                cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // 2. Validar DNI: exactamente 8 numeros
            if (txtDNI.Text.Length != 8 || SoloNumeros(txtDNI.Text) == false)
            {
                MessageBox.Show("El DNI debe contener solo números y tener exactamente 8 dígitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDNI.Focus();
                return false;
            }

            // 3. Validar Telefono: exactamente 9 numeros
            if (txtTelefono.Text.Length != 9 || SoloNumeros(txtTelefono.Text) == false)
            {
                MessageBox.Show("El teléfono debe contener solo números y tener exactamente 9 dígitos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefono.Focus();
                return false;
            }

            // 4. Validar Fecha: debe verse asi 14/10/2026
            if (txtFecha.Text.Length != 10 || txtFecha.Text[2] != '/' || txtFecha.Text[5] != '/')
            {
                MessageBox.Show("La fecha debe tener el formato DD/MM/AAAA.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFecha.Focus();
                return false;
            }

            // 5. Verificar que haya espacio en los arreglos
            if (cantidad >= 100)
            {
                MessageBox.Show("Ya no hay espacio para más documentos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        // Devuelve DOC001, DOC002, DOC003...
        string GenerarCodigo(int numeroCorrelativo)
        {
            return "DOC" + numeroCorrelativo.ToString("D3");
        }

        // Devuelve la posicion del documento o -1 si no existe
        int BuscarDocumento()
        {
            string codigo = txtCodigo.Text.ToUpper();

            for (int i = 0; i < cantidad; i++)
            {
                if (codigos[i] == codigo)
                {
                    return i;
                }
            }
            return -1;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarDocumento();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int posicion = BuscarDocumento();

            if (posicion == -1)
            {
                MessageBox.Show("Documento no encontrado");
            }
            else
            {
                MessageBox.Show("Codigo: " + codigos[posicion] + "\n" +
                                "Nombre: " + nombres[posicion] + "\n" +
                                "DNI: " + dnis[posicion] + "\n" +
                                "Telefono: " + telefonos[posicion] + "\n" +
                                "Tipo: " + tipos[posicion] + "\n" +
                                "Asunto: " + asuntos[posicion] + "\n" +
                                "Fecha: " + fechas[posicion] + "\n" +
                                "Estado: " + estados[posicion]);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarDocumentos();
        }
    }
}
