String errorMessage = "Ocorreu um erro, verifique que preencheu todos os dados corretamente e tente novamente!";
for (int i = 0; i < ex.Errors.Count; i++)
{
    if (ex.Errors[i].Message.IndexOf("A requisição não pode ser registada, pois o livro já se encontra requisitado", StringComparison.OrdinalIgnoreCase) >= 0)
    {
        errorMessage = ex.Errors[i].Message;
        break;
    }

}
MessageBox.Show(
    errorMessage + "\r\n\r\n" + ex.ToString(),
    "Erro!",
    MessageBoxButtons.OK,
    MessageBoxIcon.Error
);