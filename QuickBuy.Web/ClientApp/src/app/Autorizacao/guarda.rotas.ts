import { Injectable, ɵbypassSanitizationTrustResourceUrl } from "@angular/core";
import { Router, CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot } from "@angular/router"

@Injectable({
  providedIn:'root'
})
export class GuardaRotas implements CanActivate {

  constructor(private router: Router) {

  }


  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean  {
      this.router.navigate(['/entrar'])
        // se usuario autenticado
      return false;
    }

}
