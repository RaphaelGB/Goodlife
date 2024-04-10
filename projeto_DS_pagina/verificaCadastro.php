<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="verificarCadastro.css">
    <title>Cadastro de Cliente - Resultado</title>
</head>
<body>
    <div class="container">
        <?php
            include("bd/conexao.php");
            include("controls/cliente.php");

        $nome=$_POST['txtnome'];
        $confirm = $_POST['txtconfirm'];
        $senha=$_POST['txtsenha'];
        $dt_nasc=$_POST['txtnasc'];
        $email=$_POST['txtemail'];
        $tipo_sang=$_POST['txtsang'];
        $tel=$_POST['txttel'];

        if($senha == $confirm){
        if (inserir($conexao, $nome, $senha, $dt_nasc, $email, $tipo_sang, $tel)){
            echo "<p class='success-message'>Cliente inserido com sucesso</p>";
            echo "<a href='index.php' class='styled-button'>Voltar</a>";
            header("Location: pag_login.php");
        } else {
            $msg = mysqli_error($conexao);
            echo "<p class='error-message'>Erro, informações inseridas incorretamente: $msg</p>";
            echo "<a href='pag_cadastrar_cliente.php' class='styled-button'>Voltar</a>";
        }} else{
            echo "<script> alert('Senha incorreta')</script>";
            header("Location: pag_cadastrar_cliente.php");
        }
        ?>
    </div>
</body>
</html>
