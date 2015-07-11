FROM mono:latest

ADD . /usr/local/src/
RUN xbuild /usr/local/src/Evaluant.Calculator.Cli/NCalc.Cli.csproj 
ENTRYPOINT ["mono", "/usr/local/src/Evaluant.Calculator.Cli/bin/Debug/NCalcCli.exe"]
