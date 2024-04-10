<?php

function inserir ($conexao, $nome, $senha, $dt_nasc, $email, $tipo_sang, $tel){
    $sql = "
    insert into TB_CLIENTE
    (TB_CLIENTE_LOGIN,
     TB_CLIENTE_SENHA, 
     TB_CLIENTE_DT_NASC, 
     TB_CLIENTE_EMAIL,
      TB_CLIENTE_TIPO_SANGUINEO, 
      TB_CLIENTE_TELEFONE ) 
    VALUES 
    ('$nome', 
    $senha, 
    '$dt_nasc', 
    '$email', 
    '$tipo_sang', 
    '$tel');";
    return mysqli_query($conexao, $sql);
}


function listarAgendamentos($conexao, $id){
    $sql = "select * from tb_agendamento where tb_agendamento.TB_CLIENTE_ID = $id";
    $resultado = mysqli_query($conexao, $sql);
    return $resultado;
}
function listarClientes($conexao){
    $clientes = array();
    $resultado = mysqli_query($conexao, "select * from TB_CLIENTE");
    return $resultado;}

    function buscaCliente($conexao, $login, $senha){
    $sql = "select * from TB_CLIENTE where TB_CLIENTE_LOGIN = '$login' and TB_CLIENTE_SENHA = '$senha'";
    $result = mysqli_query($conexao, $sql);
    return mysqli_fetch_assoc($result);
}

    function buscaID($conexao, $login, $senha){
        $sql = "select * from TB_CLIENTE where TB_CLIENTE_LOGIN = '$login' and TB_CLIENTE_SENHA = '$senha'";
        $result = mysqli_query($conexao, $sql);
        return mysqli_fetch_assoc($result);
    }
function deletar($conexao,$id){
    $sql = "delete from TB_CLIENTE where TB_CLIENTE_ID = $id";
    return $result = mysqli_query($conexao,$sql);
}

function update($conexao,$login,$id){
    $sql = "update TB_CLIENTE set TB_CLIENTE_LOGIN  = '$login' where TB_CLIENTE_ID = $id";
    return $result = mysqli_query($conexao,$sql);
}

?>