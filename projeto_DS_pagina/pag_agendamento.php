<?php
session_start();
include("bd/conexao.php");
include("controls/medico.php");
include("controls/funcionario.php");
include("controls/agendamento.php");

//Verificando se o usuário está logado
if ($_SESSION['log'] != "ativo") {
    session_destroy();
    header("Location: pag_login.php");
}
    if ($_POST) {

        //mapeamento
        $data = $_POST["data"];
        $hora = $_POST["hora"];
        $especializacao = $_POST["esp"];
        $retorno = $_POST["ret"];
        
        //Pegando o crm e o nome do médico
        $busca = buscarMedico($conexao, $especializacao);
         
        $nome_medico = $busca['medico_nome'];
        $crm_medico = $busca['medico_crm'];
        

        $id_cliente = $_SESSION['Cliente_ID']; //Id do cliente
        
        //Pegando o nome e o ID do funcionario
        $funcionarios = listarFuncionarios($conexao);
        shuffle($funcionarios);
        $id_funcionario = $funcionarios[0]["TB_FUNCIONARIO_ID"];
        $nome_funcionario = $funcionarios[0]["TB_FUNCIONARIO_NOME"];
        
        if(inserirAgendamento($conexao,
        $data, $hora, 
        $retorno, $especializacao,
        $id_funcionario,$id_cliente,
        $crm_medico)){
            echo("Inserido com sucesso");
        } else{
            $error = mysqli_error($conexao);
            echo $error;
        }

    }
    ?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/pag_agendamento.css">
    <title>Agendamento de Consulta Médica</title>
</head>

<body>
    <div class="container">
        <h1>Agendamento de Consulta Médica</h1>
        <form action="" method="post">
            <label for="data">Data da Consulta:</label>
            <input type="date" name="data" required>

            <label for="hora">Hora da Consulta:</label>
            <input type="time" name="hora" required>

            <label for="especi">Especialização:</label>
            <div class="select">
                <select name="esp" id="">
                    <option>Selecione uma das especializações </option>
                <?php

            $especializacoes = listarEspecializacao($conexao);

            foreach ($especializacoes as $e):
                echo "<option> " . $e['TB_MEDICO_ESPECIALIZACAO'] . "</option>";
            endforeach;
    ?>
                </select>
                            <label for="return" id="return">Retorno:</label>
                            <select name="ret" id="">Selecione
                                <option value="true">Sim</option>
                                <option value="false">Não</option>
                            </select>
                         
                        </div>



            <input type="submit" value="Agendar Consulta">
        </form>
            <a href="index.php"><input type="submit" value="Voltar"></input></a>
    </div>
        
</body>

</html>