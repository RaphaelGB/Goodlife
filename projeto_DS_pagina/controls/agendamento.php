<?php
function inserirAgendamento($conexao, $data, $horario, $retorno, $especializacao, $id_func, $id_cliente, $crm){
    $sql = "insert into TB_AGENDAMENTO(
        TB_AGENDAMENTO_DT_CONSULTA,
        TB_AGENDAMENTO_HORARIO,
        TB_AGENDAMENTO_RETORNO,
        TB_AGENDAMENTO_ESP,
        TB_FUNCIONARIO_ID,
        TB_CLIENTE_ID,
        TB_MEDICO_CRM
        ) VALUES(
        '$data',
        '$horario',
        '$retorno',
        '$especializacao',
        $id_func,
        $id_cliente,
        $crm
        );";
    return mysqli_query($conexao, $sql);
}

function buscaIdAgendamento($conexao, $id){
    $sql = "select * from TB_AGENDAMENTO where TB_AGENDAMENTO_ID = $id;";
    $result = mysqli_query($conexao, $sql);
    return mysqli_fetch_assoc($result);
}


function listarAgendamentoIDCliente($conexao, $id){
    $sql = "select * from TB_AGENDAMENTO where TB_CLIENTE_ID = $id;";
    $result = mysqli_query($conexao, $sql);
    return mysqli_fetch_assoc($result);
}

function listarAgendamento($conexao){

 $sql = "select * from tb_agendamento;";
 $result = mysqli_query($conexao, $sql);
 return mysqli_fetch_assoc($result);
}
function deletarAgendamento($conexao,$id){

    $sql = "
    delete from tb_agendamento where tb_agendamento_id = $id;";
    return $result = mysqli_query($conexao,$sql);
}



?>