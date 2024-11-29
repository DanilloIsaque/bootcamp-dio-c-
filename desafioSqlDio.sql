#1
SELECT Nome , Ano FROM Filmes

#2
SELECT Nome , Ano FROM Filmes order by Ano

#3
SELECT Nome , Ano, Duracao FROM Filmes WHERE Nome = "De Volta para o Futuro"

#4
SELECT Nome , Ano,Duracao FROM Filmes WHERE Ano = 1997

#5
SELECT Nome , Ano,Duracao FROM Filmes WHERE Ano >2000

#6
SELECT Nome , Ano,Duracao FROM Filmes WHERE Duracao >100 AND Duracao <150

#7
SELECT Ano, COUNT(Nome) Quantidade From Filmes
GROUP BY Ano
ORDER BY Duracao DESC

#8
SELECT PrimeiroNome,UltimoNome FROM Atores WHERE Genero = "M"

#9
SELECT PrimeiroNome,UltimoNome FROM Atores ORDER BY PrimeiroNome

#10
SELECT fi.Nome, g.Genero FROM FilmesGenero f INNER JOIN Generos g ON g.Id = f.IdGenero
INNER JOIN Filmes fi ON fi.Id = f.IdFilme

#11
SELECT fi.Nome, g.Genero FROM FilmesGenero f INNER JOIN Generos g ON g.Id = f.IdGenero
INNER JOIN Filmes fi ON fi.Id = f.IdFilme 
WHERE fi.Nome = "De olhos Bem Fechados" AND g.Genero = "Mistério"

#12 
SELECT f.Nome,a.PrimeiroNome,a.UltimoNome,ef.Papel FROM ElencoFilme ef INNER JOIN Atores a ON a.Id = ef.IdFilme 
INNER JOIN Filmes f ON f.Id = fi.IdFilme








