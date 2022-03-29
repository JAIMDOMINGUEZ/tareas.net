namespace Introduccion;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblAltura;
    private TextBox? txtAltura;
    private Label? lblResultado;
    private TextBox? txtResultado;
    private Button? btnCalcular;
    private Label lblBase;
    private TextBox txtBase;
    private Label lblLado1;
    private Label lbllado2;
    private TextBox txtlado2;
    private TextBox txtlado1;
    private TextBox txtlado3;
    private Label lbllado3;

    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
        
    }
    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(300,350);

        //Etiqueta Figura
        lblFigura= new Label();
        lblFigura.Text="Figura";
        lblFigura.AutoSize=true;
        lblFigura.Location= new Point(10,10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.SelectedIndex=0;
        cmbFiguras.Location= new Point(10,40);
        cmbFiguras.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Calculo
        lblCalculo= new Label();
        lblCalculo.Text="Cálculo";
        lblCalculo.AutoSize=true;
        lblCalculo.Location= new Point(150,10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex=0;
        cmbCalculos.Location= new Point(150,40);
        cmbCalculos.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Altura
        lblAltura= new Label();
        lblAltura.Text="Altura";
        lblAltura.AutoSize=true;
        lblAltura.Location= new Point(10,80);
        lblAltura.Visible=false;
        //TextBox Altura
        txtAltura=new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location= new Point(70,75);
        txtAltura.Visible=false;
        //Etiquta Base
        lblBase= new Label();
        lblBase.Text="Base";
        lblBase.AutoSize=true;
        lblBase.Location= new Point(10,120);
        lblBase.Visible=false;
        //TextBox Altura
        txtBase=new TextBox();
        txtBase.Size = new Size(100,20);
        txtBase.Location= new Point(70,115);
        txtBase.Visible=false;
        //
        //Etiqueta lado1
        lblLado1= new Label();
        lblLado1.Text="Lado1";
        lblLado1.AutoSize=true;
        lblLado1.Location= new Point(10,81);
        lblLado1.Visible=false;
        //TextBox lado1
        txtlado1=new TextBox();
        txtlado1.Size = new Size(100,20);
        txtlado1.Location= new Point(70,76);
        txtlado1.Visible=false;
        //Etiquta lado2
        lbllado2= new Label();
        lbllado2.Text="lado2";
        lbllado2.AutoSize=true;
        lbllado2.Location= new Point(10,121);
        lbllado2.Visible=false;
        //TextBox lado2
        txtlado2=new TextBox();
        txtlado2.Size = new Size(100,20);
        txtlado2.Location= new Point(70,116);
        txtlado2.Visible=false;
        //Etiquta lado3
        lbllado3= new Label();
        lbllado3.Text="lado3";
        lbllado3.AutoSize=true;
        lbllado3.Location= new Point(10,156);
        lbllado3.Visible=false;
        //TextBox lado3
        txtlado3=new TextBox();
        txtlado3.Size = new Size(100,20);
        txtlado3.Location= new Point(70,156);
        txtlado3.Visible=false;
        //Etiqueta Resultado
        lblResultado= new Label();
        lblResultado.Text="Resultado";
        lblResultado.AutoSize=true;
        lblResultado.Location= new Point(10,250);

        //TextBox Prueba
        txtResultado=new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location= new Point(100,250);
        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(180,200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblLado1);
        this.Controls.Add(txtlado1);
        this.Controls.Add(lbllado2);
        this.Controls.Add(txtlado2);
        this.Controls.Add(lbllado3);
        this.Controls.Add(txtlado3);


    }
    private void cmb_ValueChanged(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=false;
                    lblBase.Visible=false;
                    txtlado1.Visible=false;
                    lblLado1.Visible=false;
                    txtlado2.Visible=false;
                    lbllado2.Visible=false;
                    txtlado3.Visible=false;
                    lbllado3.Visible=false; 
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=false;
                    lblBase.Visible=false;
                     txtlado1.Visible=false;
                    lblLado1.Visible=false;
                    txtlado2.Visible=false;
                    lbllado2.Visible=false;
                    txtlado3.Visible=false;
                    lbllado3.Visible=false; 
                }
            }
            if(cmbFiguras.SelectedItem.ToString()=="Rectangulo"){
               //cmbFigura.SelectedIndex==2
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                     txtlado1.Visible=false;
                    lblLado1.Visible=false;
                    txtlado2.Visible=false;
                    lbllado2.Visible=false;
                    txtlado3.Visible=false;
                    lbllado3.Visible=false; 
                    
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                    txtlado1.Visible=false;
                    lblLado1.Visible=false;
                    txtlado2.Visible=false;
                    lbllado2.Visible=false;
                    txtlado3.Visible=false;
                    lbllado3.Visible=false; 
                }
            }
            if(cmbFiguras.SelectedItem.ToString()=="Triangulo"){
               //cmbFigura.SelectedIndex==2
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=false;
                    lblAltura.Visible=false;
                    txtBase.Visible=false;
                    lblBase.Visible=false;
                    txtlado1.Visible=true;
                    lblLado1.Visible=true;
                    txtlado2.Visible=true;
                    lbllado2.Visible=true;
                    txtlado3.Visible=true;
                    lbllado3.Visible=true; 

                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                    txtlado1.Visible=false;
                    lblLado1.Visible=false;
                    txtlado2.Visible=false;
                    lbllado2.Visible=false;
                    txtlado3.Visible=false;
                    lbllado3.Visible=false; 
                }
            }

        }
        else
        {
            txtAltura.Visible=false;
            lblAltura.Visible=false;
        }
    }
    private void btnCalcular_Click(object sender, EventArgs e){
        string calculo= cmbCalculos.SelectedItem.ToString();
        
        if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
            if(txtAltura.Text!=""){
                if(calculo=="Périmetro"){
                    int altura= Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=(altura*4).ToString();
                }
                if(calculo=="Área"){
                    int altura= Convert.ToInt32(txtAltura.Text);
                    txtResultado.Text=(altura*altura).ToString();
                }
            }
              else
            {
                alerta();
            }

        }
        if(cmbFiguras.SelectedItem.ToString()=="Rectangulo"){
            if(txtAltura.Text!=""&&txtBase.Text!=""){
                if(calculo=="Périmetro"){
                    int altura= Convert.ToInt32(txtAltura.Text);
                    int basee = Convert.ToInt32(txtBase.Text);
                    txtResultado.Text=(basee*altura).ToString();
                }
                if(calculo=="Área"){
                    int altura= Convert.ToInt32(txtAltura.Text);
                    int basee = Convert.ToInt32(txtBase.Text);
                    txtResultado.Text=(2*(basee*altura)).ToString();;
                }

            }
            else
            {
                alerta();
            }
        
        }
        if(cmbFiguras.SelectedItem.ToString()=="Triangulo"){
                
                if(calculo=="Périmetro"){
                    if(txtlado1.Text!="" && txtlado2.Text!="" && txtlado3.Text!=""){
                        int lado1= Convert.ToInt32(txtlado1.Text);
                        int lado2 = Convert.ToInt32(txtlado2.Text);
                        int lado3  = Convert.ToInt32(txtlado3.Text);
                        txtResultado.Text=(lado1+lado2+lado3).ToString();
                    }
                    else{
                        alerta();
                    }
                    
                }
                if(calculo=="Área"){
                    if(txtAltura.Text!="" && txtBase.Text!=""){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        int basee = Convert.ToInt32(txtBase.Text);
                        txtResultado.Text=((basee*altura)/2).ToString();
                    }
                    else{
                        alerta();
                    }
                }
            }

    }
    private void alerta(){
        string message = "Complete los campos"; 
       
        MessageBox.Show(message,"Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Warning);
    }

}
