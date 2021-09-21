# 2021-2-T33-AULA
Exemplos da aula

## Comandos do GIT

	Para criar um novo repositorio local:
	// para iniciar o repositório
	git init

	// para adicionar o versionamento aos arquivos criados ou  modificados
	git add * 

	// para listar os arquivos (se estão versionados ou não)
	git status
	
	// para determinar o repositorio remoto (destino dos arquivos)
	git remote add origin <Endereço do servidor>**

	// para efetivar as alterações no repositório local
	git commit -m "comentário_exemplo"

	// enviar os arquivos commitados para o repositório remoto
	git push origin master

	
	//Atualizar repositório (dentro do diretório versionado):
	git pull origin master
	
	