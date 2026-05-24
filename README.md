for local access to rpi install cloudflared and add config:
~/.ssh/config
```
Host ssh.mteblesz.dev
    ProxyCommand cloudflared access ssh --hostname %h
```
then you can run `$ ssh artur-cd@ssh.mteblesz.dev` to test connection via ssh tunnel