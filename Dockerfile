FROM    mono@sha256:c2ac05aa577216cec19d985c6fb27366ee3820d93c613e742522501b72a20868

# Copy source
COPY ./App /src

WORKDIR /src
RUN nuget restore -NonInteractive

# Build
WORKDIR /src
RUN xbuild /p:Configuration=Release

# Run
CMD ["mono", "/src/bin/Release/App.exe"]