<?php
session_start();

?>

<!DOCTYPE html>
<html lang="pt-br">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />

    <link
      href="https://fonts.googleapis.com/css2?family=Roboto:wght@400;500;700;900&display=swap"
      rel="stylesheet"
    />

    <link rel="stylesheet" href="css/owl/owl.carousel.min.css" />
    <link rel="stylesheet" href="css/owl/owl.theme.default.min.css" />
    <link rel="stylesheet" href="css/magnific-popup.css" />
    <link rel="stylesheet" href="css/main.css" />
<link rel="stylesheet" href="css/pag_menu.css">
  <title>GoodLife</title>
</head>

<body>
  <!--NAVBAR-->
  <div id="header">
    <div class="container">
      <nav class="navbar navbar-expand-lg navbar-light justify-content-between">
        <a class="navbar-brand" href="#">
          <img src="img/logo.png" class="img-fluid" />
        </a>
        <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNav"
          aria-controls="navbarNav" aria-expanded="false" aria-label="Toggle navigation">
          <span class="navbar-toggler-icon"></span>
        </button>
        <div class="collapse navbar-collapse" id="navbarNav">
          <ul class="navbar-nav">
            <li class="nav-item">
              <a class="nav-link active" href="pag_login.php">Entrar</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="pag_cadastrar_cliente.php">Cadastrar-se</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="pag_agendamento.php">Agendar</a>
            </li>
            <li class="nav-item">
              <a class="nav-link" href="pag_listar_cliente.php">Agendamentos</a>
            </li>
            <li class="nav-item d-flex">
              <a class="nav-link" href="logout.php">Logout</a>
            </li>
          </ul>
        </div>
      </nav>
    </div>
  </div>
  <!--FIM NAVBAR-->

  <!--SLIDER-->
  <div id="slider" class="block">
    <div class="container pt-5">
      <div class="row">
        <div class="col-lg-4 col-md-6 align-self-center mb-md-0 mb-4">
          <h1>Atendimento na hora</h1>
          <h4 class="mb-4">Receba o melhor tratamento por um preço acessível</h4>
          <a href="pag_cadastrar_cliente.php" class="button btn btn-primary button-primary d-md-inline-block d-block mb-md-0 mb-2 mr-md-2">Cadastrar-se</a>
        </div>
        <div class="col-lg-8 col-md-6 align-self-center text-center">
          <img src="img/medica2.png" class="img-fluid" />
        </div>
      </div>
    </div>
  </div>
  <!--//SLIDER-->

  <!--SOBRE-->
  <div id="sobre" class="block">
    <div class="container">
      <div class="row">
        <div class="col-md-6 align-self-center text-center order-md-1 order-2">
          <img src="img/medica.jpg" class="img-fluid" />
        </div>
        <div class="col-md-6 align-self-center order-md-2 order-1 mb-md-0 mb-4">
          <h2 class="title">faça agora seu Agendamento</h2>
          <h4 class="subtitle">
            não deixe para cuidar da saúde depois
          </h4>
          <p>
            Localizado em cada esquina com o melhor atendimento que você poderia receber
          </p>
          <a href="pag_agendamento.php" class="btn btn-primary button button-primary">Agende agora!</a>
        </div>
      </div>
    </div>
  </div>
  <!--//SOBRE-->

<!--JS-->
<script
src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"
integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo"
crossorigin="anonymous"
></script>
<script src="js/bootstrap.min.js"></script>
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
<script src="js/owl.carousel.min.js"></script>
<script src="js/isotope.pkgd.min.js"></script>
<script src="js/magnify/jquery.magnific-popup.min.js"></script>
<script src="js/main.js"></script>
</body>

</html>