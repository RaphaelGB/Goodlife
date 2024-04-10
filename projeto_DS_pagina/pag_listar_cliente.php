<!DOCTYPE html>
<?php
session_start();
if ($_SESSION['log'] != "ativo") {
    session_destroy();
    header("Location: pag_login.php");
}

$id_cliente = $_SESSION['Cliente_ID'];

?>

<?php
            include("bd/conexao.php");
            include("controls/cliente.php");
?>

<!DOCTYPE html>
<html lang="pt-br">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/pag_listar_cliente.css">
    <title>Lista de Clientes</title>
</head>

<body>
    <header>
        <h1>Agendamentos</h1>
        <p> Olá <?php echo $_SESSION['nome']?>, estes são seus agendamentos
    </header>

    <table class="styled-table">
        <thead>
            <tr>
                <th>Data da consulta</th>
                <th>Horário</th>
                <th>Retorno</th>
                <th>Especialização</th>

            </tr>
        </thead>
        <tbody>
            <?php
            $agendamentos = listarAgendamentos($conexao, $id_cliente);
            foreach ($agendamentos as $agendamento) :
            ?>
                <tr>
                    <td><?php echo $agendamento['TB_AGENDAMENTO_DT_CONSULTA'] ?></td>
                    <td><?php echo $agendamento['TB_AGENDAMENTO_HORARIO'] ?></td>
                    <td><?php echo $agendamento['TB_AGENDAMENTO_RETORNO'] ?></td>
                    <td><?php echo $agendamento['TB_AGENDAMENTO_ESP'] ?></td>
                    </tr>
            <?php endforeach; ?>
        </tbody>
    </table>
    <div class="back-button-container">
        <a href="index.php" class="styled-button">Voltar</a>
    </div>
</body>
</html>