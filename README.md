# console-field-keyword
Usando a palavra-chave contextual field, introduzida no C# 14, para acessar o backing field em propriedades, eliminando a necessidade de declarar manualmente

![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=c-sharp&logoColor=white)
![Visual Studio Code](https://img.shields.io/badge/Visual%20Studio%20Code-0078d7.svg?style=for-the-badge&logo=visual-studio-code&logoColor=white)
![Visual Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)

## Sobre o projeto
Este projeto mostra como Usando a palavra-chave contextual field, introduzida no C# 14, para acessar o backing field em propriedades, eliminando a necessidade de declarar manualmente.

A palavra-chave <code>field</code>, permite acessar diretamente o campo de apoio gerado automaticamente por propriedades dentro dos blocos <code>get</code>, <code>set</code> ou <code>init</code>. Antes, para adicionar lógica personalizada a uma propriedade, era necessário declarar manualmente um campo privado e usá-lo nos acessores. Com <code>field</code>, o compilador cuida disso nos bastidores, tornando o código mais limpo e conciso.

Por exemplo, você pode escrever <code>set => field = value.Trim();</code> para aplicar uma transformação ao valor antes de armazená-lo, sem precisar declarar um campo como <code>_name</code>. Isso melhora a encapsulação, evita erros de acesso direto ao campo e facilita a manutenção.

>Para habilitar esse recurso, é necessário configurar o projeto para aceitar versões prévias da linguagem C# 14.

<div align="center">
    <img src="https://github.com/user-attachments/assets/33d5b19b-e10b-4fe6-91fb-ba67c2f7eea5"</img>
    <img src="https://github.com/user-attachments/assets/7ca70951-404f-43f1-af14-5f9b51d62d47"</img>
    <img src="https://github.com/user-attachments/assets/993dbbe0-6ede-4326-a5a7-1950d13f87e1"</img>
</div>

## Referências
https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-14

## Licença
GPL-3.0 license
