### AdvertApp

Starting poing on creating Advert application based on Microservice Architecture

## Run Locally

```bash
# move to service directory
cd advert-app
# build docker image
docker build -t advert-app .
# run
docker run -it --rm -p 3000:8080 --name advert-app advert-app
```
