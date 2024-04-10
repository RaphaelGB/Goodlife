<!DOCTYPE html>

<?php
session_start();

?>

<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/pag_cadastrar_cliente.css">
    <title>Cadastro de Cliente</title>
</head>
<body>
    <div class="container">
        <h1>Cadastro de Cliente</h1>
        <form action="verificaCadastro.php" method="post">
            Nome: <input type="text" name="txtnome" placeholder="Digite nome" class="InputInfo"><br>
            Data de nascimento: <input type="date" name="txtnasc" placeholder="Digite idade" class="InputInfo"><br>
            Email: <input type="text" name="txtemail" placeholder="Digite Email" class="InputInfo"><br>
            Tipo sanguíneo: <input type="text" name="txtsang" placeholder="Digite idade" class="InputInfo"><br>
            Telefone: <input type="text" name="txttel" placeholder="Digite Telefone" class="InputInfo"><br>
            
            <h2> Senha</h2>
            Senha: <br><input type="password" name="txtsenha" placeholder="Digite a senha" class="InputInfo"><br>
            Confirmar senha: <br> <input type="password" name="txtconfirm" placeholder="Confirme a senha" class="InputInfo"><br>
            
            <input type="submit" value="Cadastrar" name="btn"><br>
        </form>
        
    </div>
</body>
</html>
