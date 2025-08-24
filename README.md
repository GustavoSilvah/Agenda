<h1>📒 Agenda desenvolvida em C# Windows Forms</h1>

<p>Projeto simples desenvolvido em <strong>C# Windows Forms</strong> com banco de dados <strong>SQLite</strong>.</p>
<p>A estrutura foi organizada em camadas para facilitar manutenção e crescimento:</p>

<h2>📂 Estrutura do projeto</h2>

<ul>
  <li>
    <strong>DAL</strong><br>
    Camada de acesso a dados (Data Access Layer).<br>
    Responsável pela criação do banco, consultas e persistência dos dados.
  </li>
  <li>
    <strong>Models</strong><br>
    Entidades que representam as tabelas do banco de dados e são utilizadas pela DAL e pela interface.
  </li>
  <li>
    <strong>Util</strong><br>
    Métodos auxiliares e funções de apoio usados em diferentes partes do sistema.
  </li>
</ul>

<h2>🚀 Como rodar o projeto</h2>

<ol>
  <li>
    <strong>Clone o repositório para sua máquina.</strong>
  </li>
  <li>
    <strong>Abra a solução</strong><br>
    Use o <em>Visual Studio</em> ou qualquer IDE compatível (.NET).
  </li>
  <li>
    <strong>Execute o projeto</strong><br>
    O programa criará automaticamente o banco <code>BD_Agenda.sqlite</code> em:
    <pre><code>bin/Debug/net9.0-windows/</code></pre>
  </li>
</ol>

<h2>🧱 Tecnologias</h2>
<ul>
  <li>.NET 9 • Windows Forms</li>
  <li>SQLite</li>
</ul>
