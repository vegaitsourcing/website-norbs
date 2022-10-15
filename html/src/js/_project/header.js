import helpers from './helpers';

const header = {
	items: document.querySelectorAll('.js-dropdown-item'),
	btns: document.querySelectorAll('.js-dropdown-btn'),
	menu: document.querySelector('.js-header-menu'),
	dropdowns: document.querySelectorAll('.js-dropdown'),
	dropdownsInner: document.querySelector('.js-dropdown-list'),
	navigation: document.querySelector('.js-navigation'),
	itemActive: 'header__item--active',
	dropdownActive: 'header__dropdown--active',
	btnActive: 'header__btn--active',
	navigationActive: 'header__navigation--active',
	menuActive: 'header__menu--active',
	desktopScreen: 1200,

	init: function() {
		this.openDropdown();
		this.openNavigation();
	},

	openDropdown: function() {
		if (window.innerWidth >= this.desktopScreen) {
			this.items.forEach((item) => {
				item.addEventListener('mouseover', () => {
					const dropdown = item.querySelector('.js-dropdown');
					const btn = item.querySelector('.js-dropdown-btn');
					if (!dropdown) return;
					if (!item.classList.contains(this.itemActive)) {
						this.items.forEach((item) => {
							item.classList.remove(this.itemActive);
						});
						this.dropdowns.forEach((dropdown) => {
							dropdown.classList.remove(this.dropdownActive);
						});
						this.btns.forEach((btn) => {
							btn.classList.remove(this.btnActive);
						});
						item.classList.add(this.itemActive);
						btn.classList.add(this.btnActive);
						dropdown.classList.add(this.dropdownActive);
					}
				});
				item.addEventListener('mouseleave', () => {
					const dropdown = item.querySelector('.js-dropdown');
					const btn = item.querySelector('.js-dropdown-btn');
					if (!dropdown) return;
					btn.classList.remove(this.btnActive);
					item.classList.remove(this.itemActive);
					dropdown.classList.remove(this.dropdownActive);
				});
			});
		} else {
			this.btns.forEach((btn) => {
				btn?.addEventListener('click', () => {
					const parent = btn.closest('.js-dropdown-item');
					const dropdown = parent.querySelector('.js-dropdown');
					const dropdownInner = parent.querySelector('.js-dropdown-list');
					const height = dropdownInner.getBoundingClientRect().height;
					if (!btn.classList.contains(this.btnActive)) {
						this.btns.forEach((btn) => {
							btn.classList.remove(this.btnActive);
						});
						this.dropdowns.forEach((dropdown) => {
							dropdown.style.height = 0;
							dropdown.classList.remove(this.dropdownActive);
						});
						btn.classList.add(this.btnActive);
						dropdown.classList.add(this.dropdownActive);
						dropdown.style.height = height + 'px';
					} else {
						btn.classList.remove(this.btnActive);
						dropdown.classList.remove(this.dropdownActive);
						dropdown.style.height = 0;
					}
				});
			});
		}
	},

	openNavigation: function() {
		this.menu.addEventListener('click', () => {
			this.menu.classList.toggle(this.menuActive);
			this.navigation.classList.toggle(this.navigationActive);
			if (this.menu.classList.contains(this.menuActive)) {
				helpers.disableScroll();
			} else {
				helpers.enableScroll();
			}
		});
	}
};

export default header;
