<?php


function buscarDados($crm, $conexao){
    $sql = "select * from TB_MEDICO AS M where M.tb_medico_crm = $crm;";
    $return = mysqli_query($conexao,$sql);
    return mysqli_fetch_assoc($return);
}

function buscarMedico ($conexao, $esp){
    $sql = "select M.TB_MEDICO_NOME AS medico_nome, 
    M.TB_MEDICO_CRM as medico_crm
    from TB_MEDICO as M 
    where TB_MEDICO_ESPECIALIZACAO = '$esp';";
    $return = mysqli_query($conexao,$sql);
    return mysqli_fetch_assoc($return);
}

function listarMedico($conexao){
    $sql = "select * from TB_MEDICO";
    $result = mysqli_query($conexao, $sql);
    return mysqli_fetch_assoc($result);
}

function listarEspecializacao($conexao){
    $especializacoes = array();
    $sql = "select distinct M.TB_MEDICO_ESPECIALIZACAO from TB_MEDICO AS M";
    $result = mysqli_query($conexao, $sql);
     while ($tipo_esp = mysqli_fetch_assoc($result)){
        array_push($especializacoes, $tipo_esp);
     }
     return $especializacoes;
}
function deletarMedico($conexao, $crm){
    $sql = "delete from TB_MEDICO where TB_MEDICO_CRM = $crm;";
    $result = mysqli_query($conexao, $sql);
    return $result;
}

function updateMedico($conexao, $nome, $crm){
    $sql = " update TB_MEDICO set TB_MEDICO_NOME = '$nome' where TB_MEDICO_CRM = $crm;";
    $result = mysqli_query($conexao, $sql);
    return $result;
}



?>