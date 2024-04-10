<!DOCTYPE html>

<?php
session_start();
if($_SESSION['log'] != "ativo")
{
    session_destroy();
    header("Location: pag_login.php");
}
?>

<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Agendamento de Consulta Médica</title>
    <link rel="stylesheet" href="css/pag_agendamento.css">
</head>
<body>
    <div class="container">
        <h1>Valor da Consulta</h1>
        


            
            <label for="especi">Valor total:</label>
          
            
            <input type="submit" value="Agendar Consulta">
        </form>
    </div

    <?php
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $data = $_POST["data"];
    $hora = $_POST["hora"];
    $especi = $_POST["especi"];

    // Aqui você pode realizar o processamento do agendamento,
    // como salvar os dados em um banco de dados ou enviar por e-mail.
    
    // Exemplo simples de exibição dos dados agendados:
    echo "Consulta agendada para $data às $hora com o valor de R$ $especi.";
}
?>

</body>
</html>
