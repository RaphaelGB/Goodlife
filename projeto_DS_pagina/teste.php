<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>

<body>
    <form action="" method="post">
        
    <label for="lbl_especializacao">Especializações</label>
        
        <select name="select">
    
        <option value="">Selecione</option>
    
    <?php
            include("bd/conexao.php");
            include("controls/medico.php");

            $especializacoes = listarEspecializacao($conexao);

            foreach ($especializacoes as $e):
                echo "<option> " . $e['TB_MEDICO_ESPECIALIZACAO'] . "</option>";
            endforeach;

    
    ?>
        </select>


        <input type="submit" value="Enviar">
    </form>

    <?php
    include("bd/conexao.php");
    //ID DO CLIENTE
    include("controls/cliente.php");
    $cliente = buscaCliente($conexao, "Claudio", 12345);
    echo"<pre>";
    print_r($cliente);
    echo"</pre>";
    /*ARRAY ESPECIALIZACOES
    ";*/
        include_once("controls/medico.php");
    if($_POST){
        /* CRM E NOME DO MÉDICO
        $choose = $_POST["select"];
        $busca = buscarMedico($conexao, $choose);
        echo"<pre>";
        print_r($busca);
        echo"</pre>";
        $nome_medico = $busca['medico_nome'];
        $crm_medico = $busca['medico_crm'];
        echo "Nome do médico: ".$nome_medico.
        " Crm do médico: ". $crm_medico;*/
    
    //listando funcionarios
   //Listando e achando o funcionário
    include("controls/funcionario.php");
    $funcionarios = listarFuncionarios($conexao);
    echo"<pre>";
        print_r($funcionarios[0]);
        echo"</pre>"; 
        shuffle($funcionarios);
    $id_funcionario = $funcionarios[0]["TB_FUNCIONARIO_ID"];
    $nome_funcionario = $funcionarios[0]["TB_FUNCIONARIO_NOME"];   
            echo "<h1> O id do funcionário é: ".$id_funcionario. " o nome dele é: ".$nome_funcionario. "</h1>"; 
    }
    ?>
</body>

</html>