import { Component, OnInit } from '@angular/core';
import { dataService } from '../shared/data.service';
import { IContact } from './contact';
@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit {
  constructor(private ContactService: dataService) { }
  errorMessage: string;
  Contact: IContact = {
    Id: 0,
    City: "",
    Street: "",
    Country: "",
    FirstName: "",
    LastName: "",
    Email: "",
    State: "",
    Zip: "",
    Phone: ""
  };
  ngOnInit(): void {
    this.ContactService.getContact().subscribe({
      next: contact => this.Contact = contact,
      error: err => this.errorMessage = err
    });
  }
}
