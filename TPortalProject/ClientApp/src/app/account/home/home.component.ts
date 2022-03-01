import { Component } from '@angular/core';
import { HomeService } from 'src/app/services/home.service';
import { TokenStorageService } from 'src/app/services/token-storage.service';


@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})

export class HomeComponent {

  isLoggedIn = false;
  content: string;

  constructor(private homeService: HomeService
    , private tokenStorageService: TokenStorageService) { }

  ngOnInit(): void {
    this.isLoggedIn = !!this.tokenStorageService.getToken();
    if (this.isLoggedIn) {
      this.homeService.getContent().subscribe({
        next: data => {
          this.content = data.content   
        },
        error: err => {

        }
      });
    }
  }

}