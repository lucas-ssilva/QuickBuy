import { Component } from "@angular/core";
import { usuario } from "../../model/usuario";


@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario
  public usuarioAutenticado: boolean;
  public usuarios = ["usuario1", "usuario2,", "usuario3", "usuario4"];

  constructor() {
    this.usuario = new usuario();
  }


  entrar() {
    if (this.usuario.email == "teste@teste" && this.usuario.senha == "123") {
      this.usuarioAutenticado = true;
    }

  }
}
