import { CommonModule } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { error } from 'console';
import { response } from 'express';

@Component({
  selector: 'app-root',
  imports: [CommonModule],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit {
  ngOnInit(): void {
   this.http.get('http://localhost:5119/api/users/GetAllUsers').subscribe({
    next:response=>this.users =response,
    error:error=>console.log(error),
    complete:()=>console.log("Request has been completed")
   })
  }
  http = inject(HttpClient)
  public users:any;
  public title = 'Dating App';
}
