# Microsoft.SemanticKernel.Connectors.Chroma

This assembly contains implementation of Semantic Kernel Memory Store using [Chroma](https://docs.trychroma.com/), open-source embedding database.

**Note:** Chroma connector is verified using Chroma version **0.4.10**. Any higher versions may introduce incompatibility.

## Quickstart using local Chroma server

1. Clone Chroma:

```bash
git clone https://github.com/chroma-core/chroma.git
cd chroma
```

2. Run local Chroma server with Docker within Chroma repository root:

```bash
docker-compose up -d --build
```

3. Use Semantic Kernel with Chroma, using server local endpoint `http://localhost:8000`:
```csharp
const string endpoint = "http://localhost:8000";

ChromaMemoryStore memoryStore = new(endpoint);

Kernel kernel = new KernelBuilder()
    .WithLogger(logger)
    .WithOpenAITextEmbeddingGenerationService("text-embedding-ada-002", "OPENAI_API_KEY")
    .WithMemoryStorage(memoryStore)
    //.WithChromaMemoryStore(endpoint) // This method offers an alternative approach to registering Chroma memory store.
    .Build();
```
