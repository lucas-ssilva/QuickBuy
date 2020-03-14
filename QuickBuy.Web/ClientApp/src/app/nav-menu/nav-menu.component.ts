import { Component } from '@angular/core';
import { Router } from "@angular/router";

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent {
  isExpanded = false;

  constructor(private router: Router) {

  }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }
  public usuarioLogado(): boolean {
    //var usuariologado = sessionStorage.getItem("usuario-autenticado");
    //if (usuariologado == '1') {
      //return true;
    //return false;
    return sessionStorage.getItem("usuario-autenticado") == '1';
    }

  sair() {
    sessionStorage.setItem("usuario-autenticado", "");
    this.router.navigate(['/']);
  }
}
