import { Component, OnInit } from '@angular/core';
import { UserService } from '../services/user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.css']
})
export class UsersComponent implements OnInit {

  users?: any[] = [];

  constructor(private userService: UserService) { }

  ngOnInit() {
    this.userService.getAll().subscribe({
      next: data => {
        this.users = data;
      },
      error: err => {
        this.users = JSON.parse(err.error).message;
      }
    });
  }

}