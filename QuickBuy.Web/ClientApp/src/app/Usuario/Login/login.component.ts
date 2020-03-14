import { Component } from "@angular/core";
import { usuario } from "../../model/usuario";
import {Router } from "@angular/router"

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;


  constructor(private router:Router) {
    this.usuario = new usuario();
  }


  entrar() {
    if (this.usuario.email == "teste@teste" && this.usuario.senha == "123") {
      sessionStorage.setItem("usuario-autenticado", "1");
     this.router.navigate(['/']);
    }

  }
}
