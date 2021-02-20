# Art gallery web api

## Development

### Build docker container
```
docker build -t gallery .
docker run --rm -p 5000:80 -p 5001:443 -e ASPNETCORE_HTTPS_PORT=https://+:443 -e ASPNETCORE_URLS=http://+:80 gallery
```

### Open browser
```
http://localhost:5000/display
```