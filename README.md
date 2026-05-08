# 🤖 Asistente Financiero IA API

API inteligente para recomendación de productos de ahorro digital usando Azure OpenAI y .NET 8.

Proyecto desarrollado para una hackatón de innovación enfocada en transformación digital, autoservicio inteligente y experiencia financiera conversacional.

---

# 🚀 Objetivo

Construir un asistente virtual capaz de:

- Entender metas de ahorro
- Recomendar productos financieros digitales
- Simular ahorro aproximado
- Guiar al usuario hacia una acción digital
- Mejorar la experiencia de autoservicio

---

# ☁️ Tecnologías

## Backend
- .NET 8
- ASP.NET Core Web API
- Azure OpenAI SDK

## Inteligencia Artificial
- Azure OpenAI
- GPT-4.1 Mini
- Prompt Engineering avanzado

---

# 🧠 Arquitectura

```text
Cliente
   │
   ▼
ASP.NET Core Web API
   │
   ├── OpenAIService
   ├── Prompt Engineering
   ├── Reglas de recomendación
   └── Simulación financiera
            │
            ▼
      Azure OpenAI
```

---

# 📦 Funcionalidades

✅ Conversación inteligente  
✅ Recomendación de productos de ahorro  
✅ Simulación financiera simple  
✅ Respuestas JSON estructuradas  
✅ Integración con Azure OpenAI  
✅ Arquitectura desacoplada  
✅ API REST  

---

# 💡 Productos soportados

## Cuenta de Ahorro Digital
Ideal para:
- Emergencias
- Liquidez
- Corto plazo
- Disponibilidad inmediata

## Ahorro Programado
Ideal para:
- Viajes
- Estudios
- Compras planeadas
- Metas entre 3 y 12 meses

## CDT Digital
Ideal para:
- Largo plazo
- Planeación financiera
- Ahorro estable
- Más de 2 años

---

# 📁 Estructura del proyecto

```text
AsistenteFinancieroAPI/
│
├── Controllers/
│   └── ChatController.cs
│
├── Models/
│   ├── ChatRequest.cs
│   ├── ChatResponse.cs
│   └── Simulation.cs
│
├── Services/
│   └── OpenAIService.cs
│
├── Program.cs
├── appsettings.json
└── README.md
```

---

# 🔌 Endpoint principal

## POST `/api/chat`

### Request

```json
{
  "message": "Quiero ahorrar para un viaje en 6 meses"
}
```

### Response

```json
{
  "message": "Te recomiendo Ahorro Programado porque es ideal para metas definidas y te ayuda a ahorrar de forma organizada.",
  "recommendedProduct": "Ahorro Programado",
  "simulation": {
    "monthlyAmount": 200000,
    "months": 6,
    "estimatedSavings": 1200000
  },
  "cta": "Ir a Aportar",
  "showCta": true,
  "speakResponse": true
}
```

---

# ⚙️ Configuración local

## 1. Clonar repositorio

```bash
git clone https://github.com/TU-USUARIO/AsistenteFinancieroAPI.git
```

---

## 2. Configurar Azure OpenAI

Crear:

```text
appsettings.Development.json
```

Contenido:

```json
{
  "AzureOpenAI": {
    "Endpoint": "https://TU-ENDPOINT.openai.azure.com/",
    "ApiKey": "TU_API_KEY",
    "Deployment": "gpt-4.1-mini"
  }
}
```

---

## 3. Restaurar paquetes

```bash
dotnet restore
```

---

## 4. Ejecutar proyecto

```bash
dotnet run
```

---

# 🧠 Inteligencia Conversacional

El asistente utiliza:

- Prompt Engineering avanzado
- Reglas de recomendación financiera
- Simulación básica de ahorro
- Restricciones de cumplimiento
- Respuestas JSON estructuradas

---

# 🔒 Seguridad

⚠️ Nunca subir:
- API Keys
- Secrets
- appsettings.Development.json

El proyecto utiliza `.gitignore` para proteger información sensible.

---

# 🎯 Caso de uso

Usuario:
> "Quiero ahorrar para un viaje"

Asistente:
> "¡Qué buena meta! ¿En cuánto tiempo planeas hacer ese viaje?"

Usuario:
> "En 6 meses y puedo ahorrar 200 mil al mes"

Asistente:
> "Te recomiendo Ahorro Programado porque se ajusta a tu meta y te ayuda a ahorrar de forma organizada."

---

# 🏆 Objetivo de negocio

- Incrementar adopción digital
- Mejorar autoservicio
- Reducir fricción
- Escalar atención financiera
- Mejorar experiencia del cliente

---

# 📌 Roadmap

- [ ] Frontend conversacional
- [ ] Avatar interactivo
- [ ] Voz bidireccional
- [ ] Persistencia de conversaciones
- [ ] Analytics de uso
- [ ] Integración con productos reales

---

# 👨‍💻 Autor

Desarrollado por Juan Mavesoy para hackatón de innovación financiera e inteligencia artificial.
