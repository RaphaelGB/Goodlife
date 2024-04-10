<?php
function inserirFuncionario($conexao, $email, $nome, $senha){
    $sql = "insert into TB_FUNCIONARIO(
        TB_FUNCIONARIO_EMAIL,
        TB_FUNCIONARIO_NOME,
        TB_FUNCIONARIO_SENHA
        ) 
        VALUES(
        '$email',
        '$nome',
        $senha
        );";
        $result = mysqli_query($conexao, $sql);
        return $result;
}

function buscaFuncionario($conexao, $id){
    $sql = "select * from TB_FUNCIONARIO as F where F.TB_FUNCIONARIO_ID = $id";
    $return = mysqli_query($conexao,$sql);
    return mysqli_fetch_assoc($return);
}

function listarFuncionarios($conexao){
    $funcionarios = array();
    $sql = "select * from TB_FUNCIONARIO";
    $result = mysqli_query($conexao, $sql);
    while ($dados = mysqli_fetch_assoc($result)){
        array_push($funcionarios, $dados);
    }
    return $funcionarios;
}
function deletarFuncionario($conexao, $id){

    $sql = "delete from TB_FUNCIONARIO where TB_FUNCIONARIO_ID = $id";
    $result = mysqli_query($conexao, $sql);
    return $result;
}

function updateFuncionario($conexao, $nome, $id){
    $sql = "update TB_FUNCIONARIO set TB_FUNCIONARIO_NOME  = '$nome' where TB_FUNCIONARIO_ID = $id";
    $result = mysqli_query($conexao, $sql);
    return $result;
}



?>