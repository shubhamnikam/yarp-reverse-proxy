## Yarp Reverse Proxy
```bash
YARP is a library to help create reverse proxy servers that are high-performance, production-ready, and highly customizable.
```

#### Nuget package:
- https://www.nuget.org/packages/Yarp.ReverseProxy/


#### For more info:
- https://github.com/microsoft/reverse-proxy
- https://microsoft.github.io/reverse-proxy/articles/getting-started.html


#### Reverse Proxy Config:
- Path: ./YarpDemo.API.ReverseProxy/appsettings.json
```bash
  "ReverseProxy": {
    "Routes": {
      "order-get": {
        "ClusterId": "order-web",
        "Match": {
          "Path": "/api/Order/GetAll"
        }
      },
      "order-create": {
        "ClusterId": "order-web",
        "Match": {
          "Path": "/api/Order/Create/{id}"
        }
      },
      "order-get-mobile": {
        "ClusterId": "order-mobile",
        "Match": {
          "Path": "/mobile/api/Order/GetAll"
        },
        "Transforms": [
          {
            "PathRemovePrefix": "/mobile"
          }
        ]
      },
      "order-create-mobile": {
        "ClusterId": "order-mobile",
        "Match": {
          "Path": "/mobile/api/Order/Create/{**catch-all}"
        },
        "Transforms": [
          {
            "PathRemovePrefix": "/mobile"
          }
        ]
      },
      "payment-get": {
        "ClusterId": "payment-web",
        "Match": {
          "Path": "/api/Payment/GetAll"
        }
      },
      "payment-create": {
        "ClusterId": "payment-web",
        "Match": {
          "Path": "/api/Payment/Create/{**catch-all}"
        }
      }
    },
    "Clusters": {
      "order-web": {
        "Destinations": {
          "destination-1": {
            "Address": "http://localhost:9001"
          }
        }
      },
      "order-mobile": {
        "Destinations": {
          "destination-1": {
            "Address": "http://localhost:9001"
          }
        }
      },
      "payment-web": {
        "Destinations": {
          "destination-1": {
            "Address": "http://localhost:9002"
          }
        }
      }
    }
  }
```