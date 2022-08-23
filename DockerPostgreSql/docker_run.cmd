title Docker Build: Congratulator-Postgres Up

docker run --rm --name congratulator-postgres^
           -e POSTGRES_USER=user^
           -e POSTGRES_PASSWORD=mh8hQK8UUH^
           -e POSTGRES_DB=CongratulatorAccountsDb,CongratulatorContentDb,CongratulatorFilesDb^
           -d -p 5432:5432^
           -v ./docker-postgresql-multiple-databases:/docker-entrypoint-initdb.d^
           -v /var/lib/docker/basedata:/var/lib/postgresql/data^
           -v c:/PostgreSqlData/largedb:/mnt/largedb^
           postgres

docker logs congratulator-postgres

docker ps

pause