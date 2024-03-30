# Pãobom: Sistema de Gestão de Vendas para Padarias

# O que é o 'Pãobom'?
O Pãobom é um sistema de gestão de vendas desenvolvido como projeto de conclusão de curso na disciplina de Desenvolvimento de Aplicações. Criado especificamente para atender às necessidades de uma padaria, essa aplicação oferece uma solução abrangente para gerenciar as vendas, funcionários e estoque de forma eficiente.

# Como funciona?
Desenvolvido em C# utilizando a plataforma Windows Forms, o Pãobom oferece uma interface intuitiva e amigável para os usuários. Com recursos como cadastro de produtos, controle de vendas, a aplicação simplifica as operações diárias de uma padaria, proporcionando maior organização e controle sobre o negócio.


  
# Demonstração
<h2>Inicio</h2>
A imagem abaixo mostra a tela inicial da aplicação, onde os usuários podem iniciar suas operações e acessar facilmente os diferentes recursos oferecidos pelo Pãobom
![Inicío da aplicação](./Paobom/img/gitFormStart.png)


# Alterações a ser feitas
- Adicionar alteração de produto/funcionários
- Filtro de pesquisa em vendas, funcionários e produtos
- Bug presente no valor total (A soma não é efetuada quando mais de um produto é adicionado e a multiplicação não é feita corretamente)
- Modificar as MaskedTextBox dos valores (No atual momento elas estão formatadas da seguinte maneira 'R$  ____,__'), minha ideia é remover o 'R$ ' e adiciona-lo como label
- Ao finalizar a compra a forma crédito não está sendo efetuada da maneira correta (Algum erro na instancia e no showdialog do formulário parcelas)
