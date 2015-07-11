FROM mono:latest

Add Binaries Evaluant.Calculator Evaluant.Calculator.Cli Evaluant.Calculator.Play Evaluant.Calculator.Tests Grammar /usr/local/src/NCalc/
WORKDIR /usr/local/src/NCalc
RUN xbuild Evaluant.Calculator.Cli/NCalc.Cli.csproj 
ENTRYPOINT ["mono", "/usr/local/src/NCalc/Evaluant.Calculator.Cli/bin/Debug/NCalcCli.exe"]
