namespace Dependency.WindowsForm;

public partial class Form1 : Form
{
    readonly ProdcutRepository Repository;
    public Form1()
    {
        InitializeComponent();
        ProdcutRepository Repository =
            ApplicationHost.GetRequiredService<ProdcutRepository>();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {

        Product productFound = Repository.GetProduct(
            int.Parse(txtProductId.Text));

        if (productFound == null)
            lblResult.Text = $"Prodcuto #{txtProductId.Text} no se encuentra.";
        else
            lblResult.Text = $"Producto #{productFound.Id} {productFound.Name} encontrado";
    }
}
