FROM mcr.microsoft.com/mssql/server
ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=DevDatabase123
COPY ./sql-dev /
ENTRYPOINT [ "/bin/bash", "entrypoint.sh" ]
CMD [ "/opt/mssql/bin/sqlservr" ]