<?php
            include("bd/conexao.php");
            include("controls/cliente.php");
            if ($_POST) {
                $login = $_POST['txtu'];
                $senha = $_POST['txts'];
                if ($cliente = buscaCliente($conexao, $login, $senha)) {
                    session_start();
                    $_SESSION['Cliente_ID'] = $cliente['TB_CLIENTE_ID'];
                    $_SESSION['nome'] = $login;
                    $_SESSION['log'] = 'ativo';
                    header("Location: index.php");
                    die();
                } else {
                    echo ("<p class='error-message'>Usuário não encontrado</p>");
                }
            }
            ?>
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Login</title>
    <link rel="stylesheet" href="css/pag_login.css">
</head>
<body>
    <div class="center-container">
        <div class="login-container">
            <h1>Tela de Login</h1>
            <form class="login-form" action="" method="post">
                Usuário: <input type="text" name="txtu" placeholder="Digite login"><br><br>
                Senha: <input type="password" name="txts" placeholder="Digite senha"><br><br>
                <input type="submit" value="Logar"><br><br>
                <span>Não possui login? </span><a href="pag_cadastrar_cliente.php">Cadastre-se</a>
            </form>
           
        </div>
    </div>
</body>
</html>
