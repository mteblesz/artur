# wildcartur
Monorepo for *artur components

---
## API
available at mteblesz.dev/api

## FrontEnd
TBA

---
## Development

### RPi remote access
for remote access to rpi install cloudflared and add config to your ssh:
`~/.ssh/config`
```
Host ssh.mteblesz.dev
    ProxyCommand cloudflared access ssh --hostname %h
```
then you can run `$ ssh artur-cd@ssh.mteblesz.dev` to test connection via ssh tunnel
