FROM node:14-alpine AS build
RUN mkdir -p /app
WORKDIR /app
COPY package.json /app

RUN npm install
COPY . /app
RUN npm run build --prod

FROM nginx:1.17.1-alpine
COPY --from=build /app/dist/clientApp /usr/share/nginx/html