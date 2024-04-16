
Esse é um projeto baseado em um post no linkedin, é possível encontra-lo aqui: [✅ Parallel](https://www.linkedin.com/posts/andreluizss_c-tip-paralelismo-com-c-projeto-activity-7186046153690406912-Eu-F)

Abaixo mostro o resultado de uma pseudo chamada http, que dura 1500ms (1.5s).
E mostro que faze-las de modo sequencial, pode não ser a melhor escolha.

Quando uma chamada http não depende da outra, Parallel é sua melhor escolha.

Result:
```
Run | Sequential >> Parallel
Sequential : 00:00:04.5250782
Parallel   : 00:00:01.5096227
```
